﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppDevextreme.Data
{
    public class AppDevextremeContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public AppDevextremeContext() : base("name=AppDevextremeContext")
        {
        }

        public System.Data.Entity.DbSet<AppDevextreme.Models.Publicacion> Publicacions { get; set; }

        public System.Data.Entity.DbSet<AppDevextreme.Models.PublicacionFoto> PublicacionFotoes { get; set; }

        public System.Data.Entity.DbSet<AppDevextreme.Models.Usuario> Usuarios { get; set; }

        public System.Data.Entity.DbSet<AppDevextreme.Models.Notificacion> Notificacions { get; set; }

        public System.Data.Entity.DbSet<AppDevextreme.Models.Reaccion> Reaccions { get; set; }

        public System.Data.Entity.DbSet<AppDevextreme.Models.Comentario> Comentarios { get; set; }
    }
}
