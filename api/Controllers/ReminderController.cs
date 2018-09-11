using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using remind_me_api.Models;

namespace remind_me_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReminderController : ControllerBase
    {
        static List<Reminder> reminders = new List<Reminder>();

        // GET api/reminder/all
        [HttpGet("all")]
        public ActionResult<IEnumerable<Reminder>> Get()
        {
            return reminders;
        }

        // POST api/reminder
        [HttpPost]
        public void Post([FromBody] Reminder value)
        {
            value.Id = Guid.NewGuid().ToString();
            reminders.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}