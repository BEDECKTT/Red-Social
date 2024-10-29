using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDevextreme.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEvento { get; set; }
        public string Ubicacion { get; set; }
        public Usuario Organizador { get; set; }
        public List<Usuario> Asistentes { get; set; } = new List<Usuario>();

        public Evento() { }
    }
}