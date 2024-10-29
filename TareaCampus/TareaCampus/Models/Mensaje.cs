using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TareaCampus.Models
{
    public class Mensaje
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaEnvio { get; set; }
        public Usuario Remitente { get; set; }
        public Usuario Destinatario { get; set; }

        public Mensaje() { }
    }
}