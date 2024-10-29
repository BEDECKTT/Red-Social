using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDevextreme.Models
{
    public class ConfiguracionUsuario
    {
        public int Id { get; set; }
        public Usuario UsuarioID { get; set; }
        public string PrivacidadPerfil { get; set; }
        public string Notificaciones { get; set; }

        public ConfiguracionUsuario() { }
    }
}