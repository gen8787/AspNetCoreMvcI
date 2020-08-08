using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller //<-- add Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        // remember to use [HttpPost] attributes!
        [HttpPost("/FormPost")]
        public IActionResult FormPost(SurveyResults newSurveyResult)
        {
            return View("result", newSurveyResult);
        }

        [HttpGet("result")]
        public ViewResult Result()
        {
            return View("Result");
        }
    //<~~ E N D   O F   C O N T R O L L E R ~~> //
    }
}