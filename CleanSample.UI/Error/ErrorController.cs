using CleanSample.UI.Error;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace CleanSample.UI.Home
{
    public class ErrorController : Controller
    {

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
