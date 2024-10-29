using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TareaCampus.Models
{
    public class DBContextProject : DbContext
    {
        public DBContextProject() : base("MyDbConnectionString")
        { 
        
        }

        public DbSet<Usuario>  Usuario { get; set; }
        public DbSet<Publicacion> Publicacion { get; set; }
        public DbSet<Amistad> Amistad { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<ConfiguracionUsuario> ConfiguracionUsuario { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Mensaje> Mensaje { get; set; }
        public DbSet<MensajeMultimedia> MensajeMultimedia { get; set; }
        public DbSet<MensajeTexto> MensajeTexto { get; set; }
        public DbSet<Notificacion> Notificacion { get; set; }
        public DbSet<PublicacionEnlace> PublicacionEnlace { get; set; }
        public DbSet<PublicacionFoto> PublicacionFoto { get; set; }
        public DbSet<PublicacionVideo> PublicacionVideo { get; set; }
        public DbSet<Reaccion> Reaccion { get; set; }







    }
}