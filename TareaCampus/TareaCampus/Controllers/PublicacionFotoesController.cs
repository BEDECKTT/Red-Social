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
    public class PublicacionFotoesController : ApiController
    {
        private DBContextProject db = new DBContextProject();

        // GET: api/PublicacionFotoes
        public IQueryable<PublicacionFoto> GetPublicacion()
        {
            return db.PublicacionFoto;
        }

        // GET: api/PublicacionFotoes/5
        [ResponseType(typeof(PublicacionFoto))]
        public IHttpActionResult GetPublicacionFoto(int id)
        {
            PublicacionFoto publicacionFoto = db.PublicacionFoto.Find(id);
            if (publicacionFoto == null)
            {
                return NotFound();
            }

            return Ok(publicacionFoto);
        }

        // PUT: api/PublicacionFotoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPublicacionFoto(int id, PublicacionFoto publicacionFoto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != publicacionFoto.Id)
            {
                return BadRequest();
            }

            db.Entry(publicacionFoto).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublicacionFotoExists(id))
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

        // POST: api/PublicacionFotoes
        [ResponseType(typeof(PublicacionFoto))]
        public IHttpActionResult PostPublicacionFoto(PublicacionFoto publicacionFoto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Publicacion.Add(publicacionFoto);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = publicacionFoto.Id }, publicacionFoto);
        }

        // DELETE: api/PublicacionFotoes/5
        [ResponseType(typeof(PublicacionFoto))]
        public IHttpActionResult DeletePublicacionFoto(int id)
        {
            PublicacionFoto publicacionFoto = db.PublicacionFoto.Find(id);
            if (publicacionFoto == null)
            {
                return NotFound();
            }

            db.Publicacion.Remove(publicacionFoto);
            db.SaveChanges();

            return Ok(publicacionFoto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PublicacionFotoExists(int id)
        {
            return db.Publicacion.Count(e => e.Id == id) > 0;
        }
    }
}