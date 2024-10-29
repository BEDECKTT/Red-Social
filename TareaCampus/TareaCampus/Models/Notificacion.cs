using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TareaCampus.Models
{
    public class Notificacion
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaNotificacion { get; set; }
        public Usuario UsuarioID { get; set; }
        public Publicacion PublicacionID { get; set; }

        public Notificacion() { }
    }
}