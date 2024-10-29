using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDevextreme.Models
{
    public class PublicacionVideo : Publicacion
    {
        public string URLVideo { get; set; }
        public int Duracion { get; set; }

        public PublicacionVideo() { }
    }
}