using LearnASPNETCoreMVC5.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjekatNapredniWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjekatNapredniWeb.Controllers
{
    public class KorpaController : Controller
    {
        [Authorize(Roles = "Korisnik")]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if(cart!=null)
            {

            if(cart.Count!=0)
            {
                ViewBag.cart = cart;
                ViewBag.total = cart.Sum(item => item.Proizvod.Cena * item.Kolicina);
             }
            }
            return View();
        }

        [Authorize(Roles = "Korisnik")]
        public IActionResult Buy(int  id)
        {
            ProizvodDataAccessLayer objproizvod = new ProizvodDataAccessLayer();
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Proizvod = objproizvod.PodaciOProizvodu(id), Kolicina = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Kolicina++;
                }
                else
                {
                    cart.Add(new Item { Proizvod = objproizvod.PodaciOProizvodu(id), Kolicina = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                
            }
            this.TempData["Message"] = "Success!";
            return RedirectToAction("ProizvodViewKorisnik","Proizvod");
        }

        [Authorize(Roles = "Korisnik")]
        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            if (cart.Count != 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
              return RedirectToAction("ProizvodViewKorisnik","Proizvod");   
            }
        }

        [Authorize(Roles = "Korisnik")]
        [HttpPost]
        public IActionResult KreirajOrder(List<Item> items, Order order)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ProizvodDataAccessLayer objproizvod = new ProizvodDataAccessLayer();
            if (ModelState.IsValid)
            {
                items = cart;
                objproizvod.NapraviOrder(items,order);
                this.TempData["Poruka"] = "Success!";
                return RedirectToAction("ProizvodViewKorisnik", "Proizvod");
            }
            return View(items);
        }

        private int isExist(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Proizvod.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
