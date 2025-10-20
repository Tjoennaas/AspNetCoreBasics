


// https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio



//using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Ping;

namespace Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Ping> GetPing()
        {
            Ping ping = new Ping();


            if (ping == null)
            {
                return NoContent();
            }

            return Ok(ping);
        }
    }



    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {

        [HttpGet]
        public ActionResult GetTime()
        {
            DateTime localDate = DateTime.Now; //https://learn.microsoft.com/en-us/dotnet/api/system.datetime.now?view=net-9.0


            return Ok(localDate);

        }
    }
}

