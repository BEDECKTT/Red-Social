using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TareaCampus.Models
{
    public class PublicacionFoto : Publicacion
    {
        public string URLFoto { get; set; }
        public PublicacionFoto() { }
    }
}