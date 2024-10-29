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
    public class ComentariosController : ApiController
    {
        private DBContextProject db = new DBContextProject();

        // GET: api/Comentarios
        public IQueryable<Comentario> GetComentario()
        {
            return db.Comentario;
        }

        // GET: api/Comentarios/5
        [ResponseType(typeof(Comentario))]
        public IHttpActionResult GetComentario(int id)
        {
            Comentario comentario = db.Comentario.Find(id);
            if (comentario == null)
            {
                return NotFound();
            }

            return Ok(comentario);
        }

        // PUT: api/Comentarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutComentario(int id, Comentario comentario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != comentario.Id)
            {
                return BadRequest();
            }

            db.Entry(comentario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComentarioExists(id))
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

        // POST: api/Comentarios
        [ResponseType(typeof(Comentario))]
        public IHttpActionResult PostComentario(Comentario comentario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Comentario.Add(comentario);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = comentario.Id }, comentario);
        }

        // DELETE: api/Comentarios/5
        [ResponseType(typeof(Comentario))]
        public IHttpActionResult DeleteComentario(int id)
        {
            Comentario comentario = db.Comentario.Find(id);
            if (comentario == null)
            {
                return NotFound();
            }

            db.Comentario.Remove(comentario);
            db.SaveChanges();

            return Ok(comentario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ComentarioExists(int id)
        {
            return db.Comentario.Count(e => e.Id == id) > 0;
        }
    }
}