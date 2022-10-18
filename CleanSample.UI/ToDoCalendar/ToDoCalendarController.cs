using Microsoft.AspNetCore.Mvc;


namespace CleanSample.UI.Home
{
    public class ToDoCalendarController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
