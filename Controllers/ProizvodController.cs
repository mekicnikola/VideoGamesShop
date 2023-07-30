using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using ProjekatNapredniWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjekatNapredniWeb.Controllers
{
    public class ProizvodController : Controller
    {
        //------------------------lokalizacija pocetak
        public IStringLocalizer<Resource> localizer;

        public ProizvodController(IStringLocalizer<Resource> localizer)
        {
            this.localizer = localizer;
        }
        //------------------------lokalizacija kraj

        ProizvodDataAccessLayer objproizvod = new ProizvodDataAccessLayer();

        //-------------------------------admin pocetak

        [Authorize(Roles = "Admin")]
        public IActionResult ProizvodVIew()
        {
            List<Proizvod> proizvodi = new List<Proizvod>();
            proizvodi = objproizvod.PrikazSvihProizvoda().ToList();
            //ViewBag.Products = proizvodi;
            return View(proizvodi);
        }

        

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync([Bind] Proizvod proizvod, IFormFile uploadFile)
        {
            if (uploadFile != null && uploadFile.Length > 0)
            {
                var fileName = Path.GetFileName(uploadFile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var fileSrteam = new FileStream(filePath, FileMode.Create))
                {
                    await uploadFile.CopyToAsync(fileSrteam);
                }
                proizvod.Slika = fileName;
            }

            if (ModelState.IsValid)
            {
                objproizvod.UbaciProizvod(proizvod);
                return RedirectToAction("ProizvodView");
            }
            return View(proizvod);
        }

        [Authorize(Roles = "Admin")]
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

        [Authorize(Roles = "Admin")]
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

        [Authorize(Roles = "Admin")]
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

        //-------------------------------admin kraj


        //-------------------------------korisnik pocetak
        public IActionResult ProizvodVIewKorisnik()
        {
            List<Proizvod> proizvodi = new List<Proizvod>();
            proizvodi = objproizvod.PrikazSvihProizvoda().ToList();

            return View(proizvodi);
        }

        public IActionResult DetailsKorisnik(int? id)
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

        //-------------------------------korisnik kraj
    }
}
