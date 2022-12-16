using Microsoft.AspNetCore.Mvc;
using Pract01_ASP_RubenPeña.Context;
using Pract01_ASP_RubenPeña.Models;
using Pract01_ASP_RubenPeña.Services;
using System.Diagnostics;

namespace Pract01_ASP_RubenPeña.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ContextDB contextDB;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Vname = "AUTHOR: RUBÉN PEÑA GIMÉNEZ";
            ViewBag.V2 = "I'm going to be the best WEB Designer!!";
            return View();
        }

        public IActionResult Proyectos()
        {
            ViewBag.Vproject = new RepositoryOfProjects().GetProjects();
            // ViewBag.Vproject = contextDB.ClassProjects.ToList();
            return View();
        }
        public IActionResult FormAca()
        {
            ViewBag.VformAca = new RepositoryOfFormAca().GetFormAca();
            return View();
        }
        public IActionResult Exp()
        {
            ViewBag.Vexp = new RepositoryOfExp().GetExp();
            return View();
        }

        public IActionResult SobreMi()
        {
            ViewBag.Vsobre = new RepositoryOfSobreMi().GetSobreMi();
            return View();
        }
        public IActionResult ConTec()
        {
            ViewBag.Vcontec = new RepositoryOfConTec().GetConTec();
            return View();
        }
        public IActionResult DescCV()
        {
            ViewBag.VdescCV = new RepositoryOfDescCV().GetDescCV();
            return View();
        }
        public IActionResult Contacto()
        {
            ViewBag.Vcontacto = new RepositoryOfContacto().GetContacto();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}