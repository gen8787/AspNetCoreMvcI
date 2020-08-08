using System;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers
{
    public class HomeController : Controller //<-- add Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            DateTime GetCurrentDateTime = DateTime.Now;
            string NewDate = GetCurrentDateTime.ToString("MMM dd, yyyy");
            string NewTime = GetCurrentDateTime.ToString("hh:mm tt");
            ViewBag.NewDate = NewDate;
            ViewBag.NewTime = NewTime;

            return View("Index");
        }
    }
}