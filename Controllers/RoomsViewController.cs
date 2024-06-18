using Backend_Zenicaorb.ApplicationData;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Zenicaorb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsViewController : Controller
    {
        public static PetSuiteDbContext context = new PetSuiteDbContext();
        [HttpGet]
        [Route("get")]
        public ActionResult<IEnumerable<RoomsView>> GetRoomsView()
        {
            try
            {
                var data = context.RoomsViews.ToList();
                return data;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ошибка сервера");
            }
        }
    }
}
