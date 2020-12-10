using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPPastabar.Models;
using ASPPastabar.Services;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ASPPastabar.Controllers
{
    public class HomeController : Controller
    {
        private PastaService _bestellingenService;

        public HomeController(PastaService bestellingenService)
        {
            _bestellingenService = bestellingenService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nieuwsbrief()
        {
            return View();
        }

        public IActionResult Mandje()
        {
            return View(_bestellingenService.ShowAll());
        }

        [HttpPost]
        public IActionResult Mandje(Pasta p)
        {
            if (this.ModelState.IsValid)
            {
                return RedirectToAction("Besteld", p);
            }
            else
                return View(p);
        }

        [HttpPost]
        public IActionResult Nieuwsbrief(Persoon p)
        {
            if (this.ModelState.IsValid)
            {
                return RedirectToAction("Bevestiging", p);
            }
            else
                return View(p);
        }

        public IActionResult Bevestiging(Persoon p)
        {
            return View(p);
        }

        public IActionResult Besteld(Pasta p)
        {
            return View();
        }

        public IActionResult Toevoegen()
        {
            var pasta = new Pasta();
            return View(pasta);
        }

        [HttpPost]
        public IActionResult Toevoegen(Pasta p)
        {

            if (this.ModelState.IsValid)
            {
                _bestellingenService.Add(p);
                return RedirectToAction("Index");
            }
            else
                return View(p);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}