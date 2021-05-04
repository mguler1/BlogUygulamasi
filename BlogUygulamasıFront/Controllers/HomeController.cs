using Microsoft.AspNetCore.Mvc;

namespace BlogUygulamasıFront.Controllers{
    public class HomeController:Controller
    {
            public IActionResult Index()
            {
                return View();
            }
    }
}