using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDevextreme.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaComentario { get; set; }
        public Usuario Autor { get; set; }
        public Publicacion PubliacionID { get; set; }

        public Comentario() { }
    }
}