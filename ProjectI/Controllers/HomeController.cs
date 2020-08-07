using Microsoft.AspNetCore.Mvc;

namespace ProjectI.Controllers
{
    public class HomeController : Controller //<-- add Controller
    {
        //Requests
        //localhoset:5000/
        [HttpGet("")]
        public string Index()
        {
            return "This is my Index!";
        }

        //localhoset:5000/projects
        [HttpGet("/projects")]
        public string Proj()
        {
            return "These are my projects.";
        }

        [HttpGet("/contact")]
        public string Cont()
        {
            return "This is my contact!";
        }

        //localhost:5000/users/???
        [HttpGet("users/{username}")]
        public string HelloUser(string username)
        {
            return $"Hello, {username}";
        }
    //<~~ E N D   O F   C O N T R O L L E R ~~> //
    }
}