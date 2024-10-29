using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDevextreme.Models
{
    public class MensajeMultimedia : Mensaje
    {
        public string URLMultimedia { get; set; }
        public string TipoMultimedia { get; set; }
        public MensajeMultimedia() { }
    }
}