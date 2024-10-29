using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace AppDevextreme.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechadeNacimiento { get; set; }
        public string FotoPerfil { get; set; }
        public string Biografia { get; set; }

       
    }
}