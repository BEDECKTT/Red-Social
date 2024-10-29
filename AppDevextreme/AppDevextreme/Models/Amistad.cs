using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDevextreme.Models
{
    public class Amistad
    {
        public int Id { get; set; }
        public int UsuarioID1 { get; set; }
        public int UsuarioID2 { get; set; }
        public DateTime FechaAmistad { get; set; }

        public Amistad() { }
    }
}