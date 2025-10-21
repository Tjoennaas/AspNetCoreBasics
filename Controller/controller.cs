


//  https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio



using Microsoft.AspNetCore.Mvc;
using Models;


namespace Controller;


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


    //----------------------------------//



    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {      private static readonly List<Message> _messages = new()
        {
            new Message(1, "Hei"),
            new Message(2, "Hade")
        };

        private static int _nextId = 3;
          

        [HttpGet]
        public ActionResult<Message> getMessags() => Ok( _messages);




    [HttpGet("{Id}")]


    public ActionResult<Message> getMessagById(int Id)
    {
        var message = _messages.FirstOrDefault(m => m.Id == Id);

        if (message == null)
        {

            return NotFound();
        }
            return Ok(message);
}


    [HttpPost]
    public ActionResult<Message> CreateMessage(Message input)
    {
        // Gi meldingen et nytt id
        input.Id = _nextId++;

        // Legg den til i lista
        _messages.Add(input);

        return Created($"api/messages/{input.Id}", input);

    }

        [HttpDelete("{Id:int}")]
        public ActionResult<Message> deletById(int Id)
        {
              var message = _messages.FirstOrDefault(m => m.Id == Id);

        if (message == null)
        {
            return NotFound();
        }
             
         _messages.Remove(message);

            return NoContent();
        }

    };












