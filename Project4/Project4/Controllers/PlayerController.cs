using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project4.Models;
using Project4.RequestModel;

namespace Project4.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly Assignment2Context _assignment;
        public PlayerController(Assignment2Context assignmentcs)
        {
            _assignment = assignmentcs;
        }
        
        [HttpGet]
        public IActionResult Get1()
        {
            var player = _assignment.Player.ToList();
            return Ok(player);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
           


                var result = _assignment.Player.First(obj => obj.PlayerId == id);
                
                return Ok(result);
            

        }

        [HttpGet("Player/{value}")]
        public IActionResult Get(string value)
        {



            var result = _assignment.Player.Where(obj => obj.PlayerName.Contains(value));
            return Ok(result);



        }

        [HttpPost]
        public void Post([FromBody] PlayerRequest value)      // request come from body
        {
            //object
            Player obj = new Player();
            obj.PlayerId = value.PlayerId;
            obj.PlayerName = value.PlayerName;
            obj.JerseyNo = value.JerseyNo;
            obj.Age = value.Age;
            obj.Country = value.Country;
            obj.Dob = value.Dob;
            obj.Gender = value.Gender;
            obj.Sport = value.Sport;
            _assignment.Player.Add(obj);
            _assignment.SaveChanges();
        }

        // GET: api/Player
        /*
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Player/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Player
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Player/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
