using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using vue3.Models;

namespace vue3.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string namedata="")
    {
        if(namedata!="")
            return View(new FileInfo2(){FileName=namedata});

        // Response.Redirect()
        return View();
    }

    [HttpGet]
    public IActionResult Privacy()
    {
        return View("Fupload");
        // return View("../Views/Fupload.cshtml");
    }

    [HttpGet]
    public IActionResult Fupload()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Fupload(IFormFile file)
    {
        // System.IO.File.AppendAllText(@"d:\Logs\aaa.txt",file.FileName);
        // Response.Redirect();

        FileInfo2 model = new FileInfo2();
        model.FileName = file.FileName;
        return View("Index", model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel() { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
