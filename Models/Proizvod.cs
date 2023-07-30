using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjekatNapredniWeb.Models
{
    public partial class Proizvod
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Izdavac { get; set; }
        public string Zanr { get; set; }
        public string Platforma { get; set; }
        public DateTime DatumIzlaska { get; set; }
        public string Slika { get; set; }
    }
}
