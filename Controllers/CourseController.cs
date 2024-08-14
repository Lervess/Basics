
using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers;

public class CourseController: Controller {
    
    public IActionResult Index() {
        
        var kurs = new Course();

        kurs.Id = 1;
        kurs.Title = "ASP.NET Core 8";
        kurs.Description = "ASP.NET Core 8 Öğreniyorum";

        return View(kurs);
    }

    public IActionResult List() {

        var kurslar = new List<Course> {
            new Course() {Id=1,Title="ASP.NET Core 8",Description="ASP.NET Core 8 Öğreniyorum",Image="philips.png"},
            new Course() {Id=2,Title="ASP.NET Core 9",Description="ASP.NET Core 9 Öğreniyorum",Image="philips.png"},
            new Course() {Id=3,Title="ASP.NET Core 10",Description="ASP.NET Core 10 Öğreniyorum",Image="philips.png"},
        };


        return View(kurslar);
    }
}

