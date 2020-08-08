using System;
using Microsoft.AspNetCore.Mvc;

namespace ProjectI.Controllers
{
    public class HomeController : Controller //<-- add Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            ViewBag.SayHello = "Hello!";
            ViewBag.ProfPicUrl = "http://rawclimbing.com/wp-content/uploads/2020/03/IMG_0705.jpeg";
            return View("Index");
        }

        [HttpGet("/projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("/contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }



        //localhost:5000/users/???
        [HttpGet("users/{username}")]
        public string HelloUser(string username)
        {
            return $"Hello, {username}";
        }

        public RedirectToActionResult Method()
        {
            // The anonymous object consists of keys and values
            // The keys should match the parameter names of the method being redirected tocopy
            return RedirectToAction("OtherMethod", new { Food = "sandwiches", Quantity = 5 });
        }
        

        [HttpGet]
        [Route("other/{Food}/{Quantity}")]
        public ViewResult OtherMethod(string Food, int Quantity)
        {
            Console.WriteLine($"I ate {Quantity} {Food}.");
            return View();
        }
    //<~~ E N D   O F   C O N T R O L L E R ~~> //
    }
}