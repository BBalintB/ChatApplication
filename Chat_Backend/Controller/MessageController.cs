using Chat_Backend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Chat_Backend.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        Logic logic;
        IHubContext<SignalRHub> hub;

        public MessageController(Logic logic, IHubContext<SignalRHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Message> Get()
        {
            return logic.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody]Message message)
        {
            ;
            logic.Post(message);
            this.hub.Clients.All.SendAsync("MessageCreated", message);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
