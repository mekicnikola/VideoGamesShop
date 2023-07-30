using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjekatNapredniWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjekatNapredniWeb.Controllers
{
    public class OrderController : Controller
    {
        OrderDataAccessLayer objorder = new OrderDataAccessLayer();

        [Authorize(Roles = "Admin")]
        public IActionResult OrderView()
        {
            List<Order> porudzbine = new List<Order>();
            List<Item> itemi = new List<Item>();
            porudzbine = objorder.PrikazSvihPorudzbina().ToList();
            itemi = objorder.PrikazSvihItema().ToList();
            ViewData["Itemi"] = itemi.ToList();

            if (porudzbine != null && itemi!=null)
            {
                if (porudzbine.Count != 0 && itemi.Count!=0)
                {
                    ViewData["Itemi"] = itemi.ToList();
                }
            }


            return View(porudzbine);
        }
    }
}
