using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TareaCampus.Models
{
    public class Reaccion
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaReaccion { get; set; }
        public Usuario UsuarioID { get; set; }
        public Publicacion PublicacionID { get; set; }

        public Reaccion() { }
    }
}