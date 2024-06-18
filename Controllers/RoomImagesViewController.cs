using Backend_Zenicaorb.ApplicationData;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Zenicaorb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomImagesViewController : Controller
    {
        public static PetSuiteDbContext context = new PetSuiteDbContext();
        [HttpGet]
        [Route("get/{roomId}")]
        public ActionResult<IEnumerable<RoomImagesView>> GetRoomImagesView(int roomId)
        {
            try
            {
                var data = context.RoomImagesViews.Where(x => x.RoomId == roomId).ToList();
                return data;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ошибка сервера");
            }
        }
    }
}
