using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjekatNapredniWeb.Models
{
    public partial class Proizvod
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Naziv")]
        public string Naziv { get; set; }

        [Display(Name = "Cena")]
        public float Cena { get; set; }

        [Display(Name = "Izdavac")]
        public string Izdavac { get; set; }

        [Display(Name = "Zanr")]
        public string Zanr { get; set; }

        [Display(Name = "Platforma")]
        public string Platforma { get; set; }

        [Display(Name = "DatumIzlaska")]
        public DateTime DatumIzlaska { get; set; }

        [Display(Name = "Slika")]
        public string Slika { get; set; }
    }
}
