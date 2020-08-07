using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers
{
    public class HomeController : Controller //<-- add Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("index");
        }
        
    //<~~ E N D   O F   C O N T R O L L E R ~~> //
    }
}