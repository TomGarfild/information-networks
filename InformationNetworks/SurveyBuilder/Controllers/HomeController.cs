using Microsoft.AspNetCore.Mvc;

namespace SurveyBuilder.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Error()
    {
        return View();
    }
}