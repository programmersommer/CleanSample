using Microsoft.AspNetCore.Mvc;

namespace CleanSample.UI.Contact
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
