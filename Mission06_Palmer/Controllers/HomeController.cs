using Microsoft.AspNetCore.Mvc;

namespace Mission06_Palmer.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
   
}