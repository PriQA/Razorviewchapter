using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        static private List<string> Events = new List<string>();
        [HttpGet]
        public IActionResult Index()
        {

            //Events.Add("Strange Loop");
            //Events.Add("Grace Hopper");
            //Events.Add("Code with Pride");
            ViewBag.Events = Events;    

            return View();
        }

        [HttpGet]

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]

        public IActionResult NewEvent(string eventName)
        {
            Events.Add(eventName);
            return Redirect("/Events");
        }

    }
}
