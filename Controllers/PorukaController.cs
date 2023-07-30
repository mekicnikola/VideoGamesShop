using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjekatNapredniWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjekatNapredniWeb.Controllers
{
    public class PorukaController : Controller
    {
        PorukaDataAccessLayer objporuka = new PorukaDataAccessLayer();

        [Authorize(Roles = "KorServis")]
        public IActionResult PorukaVIew()
        {
            List<Poruka> poruke = new List<Poruka>();
            poruke = objporuka.PrikazSvihPoruka().ToList();
            return View(poruke);
        }


        [Authorize(Roles = "Korisnik")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Poruka poruka)
        {
            if (ModelState.IsValid)
            {
                objporuka.KreirajPoruku(poruka);
                this.TempData["UspesnaPoruka"] = "Success!";
                return RedirectToAction("ProizvodViewKorisnik","Proizvod");
            }
            return View(poruka);
        }
    }
}
