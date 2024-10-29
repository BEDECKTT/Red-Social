using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDevextreme.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Usuario> Administradores { get; set; } = new List<Usuario>();
        public List<Usuario> Miembros { get; set; } = new List<Usuario>();
        public List<Publicacion> Publicaciones { get; set; } = new List<Publicacion>();

        public Grupo() { }
    }
}