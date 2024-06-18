using Backend_Zenicaorb.ApplicationData;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Zenicaorb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : Controller
    {
        public static PetSuiteDbContext context = new PetSuiteDbContext();

        public class Reserv()
        {
            public string Name { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Wishes { get; set; }
            public int StatusId { get; set; }
            public int RoomId { get; set; }
            public int UserId { get; set; }
            public int PetWeight { get; set; }
            public int PetHeight { get; set; }
            public bool IsVideoSurveillance { get; set; }
            public bool IsPhotoReports { get; set; }
            public decimal TotalCost { get; set; }
        };

        [HttpPost]
        [Route("reserve")]
        public ActionResult<IEnumerable<Reserv>> CreateReservation([FromBody]Reserv reserv)
        {
            Reservation reservation = new Reservation()
            {
                Name = "Бронь" + $" №{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Hour}",
                StartDate = reserv.StartDate,
                EndDate = reserv.EndDate,
                Wishes = reserv.Wishes,
                StatusId = reserv.StatusId,
                RoomId = reserv.RoomId,
                UserId = reserv.UserId,
                PetWeight = reserv.PetWeight,
                PetHeight = reserv.PetHeight,
                IsVideoSurveillance = reserv.IsVideoSurveillance,
                IsPhotoReports = reserv.IsPhotoReports,
                TotalCost = reserv.TotalCost,
            };

            context.Reservations.Add(reservation);
            context.SaveChanges();
            var data = context.Reservations.Where(x => x.UserId == reserv.UserId).ToList();
            return Ok(data);
        }
        [HttpGet]
        [Route("get/{userId}")]
        public ActionResult<IEnumerable<Reservation>> GetReservationsByUserId(int userId)
        {
            try
            {
                var data = context.Reservations.Where(x => x.UserId == userId).ToList();
                return data;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ошибка сервера");
            }
        }
    }
}
