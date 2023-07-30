using Microsoft.AspNetCore.Mvc;
using ProjekatNapredniWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjekatNapredniWeb.Controllers
{
    public class ProizvodController : Controller
    {
        ProizvodDataAccessLayer objproizvod = new ProizvodDataAccessLayer();
        public IActionResult ProizvodVIew()
        {
            List<Proizvod> proizvodi = new List<Proizvod>();
            proizvodi = objproizvod.PrikazSvihProizvoda().ToList();

            return View(proizvodi);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                objproizvod.UbaciProizvod(proizvod);
                return RedirectToAction("ProizvodView");
            }
            return View(proizvod);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Proizvod proizvod = objproizvod.PodaciOProizvodu(id);

            if (proizvod == null)
            {
                return NotFound();
            }
            return View(proizvod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind] Proizvod proizvod)
        {
            if (id != proizvod.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objproizvod.IzmeniProizvod(proizvod);
                return RedirectToAction("ProizvodView");
            }
            return View(proizvod);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Proizvod proizvod = objproizvod.PodaciOProizvodu(id);

            if (proizvod == null)
            {
                return NotFound();
            }
            return View(proizvod);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Proizvod proizvod = objproizvod.PodaciOProizvodu(id);

            if (proizvod == null)
            {
                return NotFound();
            }
            return View(proizvod);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            objproizvod.ObrisiProizvod(id);
            return RedirectToAction("ProizvodView");
        }
    }
}
