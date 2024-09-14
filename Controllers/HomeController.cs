using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using vue3.Models;

namespace vue3.Controllers;

public class HomeController : Controller
{
    ActionResult NOK = new OkResult();

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
    public async IActionResult Fupload(IFormFile file)
    {
        // System.IO.File.AppendAllText(@"d:\Logs\aaa.txt",file.FileName);
        // Response.Redirect();
        if(file == null)
        {return NoContent();}//Accepted()
        // return Accepted();

        // file.OpenReadStream()

        // await 
        // await Encoding.UTF8.GetBytes());//TryGetBytes//.GetBytes());
        // await Encoding.UTF8.GetBytes(file.OpenReadStream());//TryGetBytes//.GetBytes());
        
        // System.IO.File.WriteAllBytes("" ,await Encoding.UTF8.GetBytes());
        ;
        // {return NoContent();}//Accepted()

        // await file.OpenReadStream().BeginWrite("",,,,);

        // System.IO.FileStream fs = new FileStream("",FileMode.CreateNew);
        // await fs.WriteAsync();
        // FileInfo2 model = new FileInfo2();
        // // model.FileName = file.FileName;
        
        await System.IO.File.AppendAllTextAsync("","" );

        return View("Index");
        // return View("Index", model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel() { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
