using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GeoSphereGenerator.Models;

namespace GeoSphereGenerator.Controllers;

public class CircleController : Controller
{
    public IActionResult App()
    {
        return View();
    }

    [HttpPost]
    public IActionResult GenerateCircle(Circle circle)
    {
        return View("App", circle);
    }

}
