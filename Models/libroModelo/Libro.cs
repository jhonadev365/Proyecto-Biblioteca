using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CondoriApazaJhonatan_2doParcial.Models.libroModelo
{
    public partial class Libro
    {
        public string Isbn { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Edicion { get; set; }
        public DateTime? Año { get; set; }
    }
}
