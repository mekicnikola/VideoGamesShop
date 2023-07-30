using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjekatNapredniWeb.Models
{
    public class Item
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Proizvod Proizvod { get; set; }
        public int Kolicina { get; set; }
    }
}
