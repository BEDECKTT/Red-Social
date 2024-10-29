using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TareaCampus.Models;

namespace TareaCampus.Models
{
    public class Publicacion
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public Usuario Autor {  get; set; }
    


        public Publicacion() { }    
    }
}