using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjekatNapredniWeb.Models
{
    public class Poruka
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public DateTime Datum { get; set; }
        public string PorukaSadrzaj { get; set; }
        public string Email { get; set; }
    }
}
