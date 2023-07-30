using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjekatNapredniWeb.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public string Adresa { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public float Suma { get; set; }
    }
}
