using Microsoft.AspNetCore.Mvc;


namespace CleanSample.UI.Home
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        } 
    }
}
