using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TareaCampus.Models;

namespace TareaCampus.Controllers
{
    public class PublicacionsController : ApiController
    {
        private DBContextProject db = new DBContextProject();

        // GET: api/Publicacions
        public IQueryable<Publicacion> GetPublicacion()
        {
            return db.Publicacion;
        }

        // GET: api/Publicacions/5
        [ResponseType(typeof(Publicacion))]
        public IHttpActionResult GetPublicacion(int id)
        {
            Publicacion publicacion = db.Publicacion.Find(id);
            if (publicacion == null)
            {
                return NotFound();
            }

            return Ok(publicacion);
        }

        // PUT: api/Publicacions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPublicacion(int id, Publicacion publicacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != publicacion.Id)
            {
                return BadRequest();
            }

            db.Entry(publicacion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublicacionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Publicacions
        [ResponseType(typeof(Publicacion))]
        public IHttpActionResult PostPublicacion(Publicacion publicacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Publicacion.Add(publicacion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = publicacion.Id }, publicacion);
        }

        // DELETE: api/Publicacions/5
        [ResponseType(typeof(Publicacion))]
        public IHttpActionResult DeletePublicacion(int id)
        {
            Publicacion publicacion = db.Publicacion.Find(id);
            if (publicacion == null)
            {
                return NotFound();
            }

            db.Publicacion.Remove(publicacion);
            db.SaveChanges();

            return Ok(publicacion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PublicacionExists(int id)
        {
            return db.Publicacion.Count(e => e.Id == id) > 0;
        }
    }
}