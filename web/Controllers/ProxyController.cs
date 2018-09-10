using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

public class ProxyController : Controller
{
    public ProxyController()
    {
        var client = new RestClient("http://example.com");
    }
    public IActionResult SaveReminder([FromBody] Reminder reminder)
    {
        return Ok();
    }
    public IActionResult GetAllReminders()
    {
        var reminders = new List<Reminder>();
        reminders.Add(new Reminder { Id = "1", Title = "Test Title", DueDate = DateTime.Today });
        return Ok(reminders);
    }
    public IActionResult DeleteReminder(string reminderId)
    {
        return Ok();
    }
}