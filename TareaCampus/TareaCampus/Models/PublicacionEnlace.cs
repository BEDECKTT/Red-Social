using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TareaCampus.Models
{
    public class PublicacionEnlace : Publicacion
    {
        public string URLEnlace { get; set; }

        public PublicacionEnlace() { }
    }
}