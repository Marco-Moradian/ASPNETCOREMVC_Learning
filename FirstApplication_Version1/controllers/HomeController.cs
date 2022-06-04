

namespace FirstApplication_Version1.controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        // I added this because compiler handle this behind of the scene
        public HomeController() : base ()
        {

        }
        public Microsoft.AspNetCore.Mvc.IActionResult Index()
        {
            return View();
        }
    }
}
