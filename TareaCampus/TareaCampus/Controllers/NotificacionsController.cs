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
    public class NotificacionsController : ApiController
    {
        private DBContextProject db = new DBContextProject();

        // GET: api/Notificacions
        public IQueryable<Notificacion> GetNotificacion()
        {
            return db.Notificacion;
        }

        // GET: api/Notificacions/5
        [ResponseType(typeof(Notificacion))]
        public IHttpActionResult GetNotificacion(int id)
        {
            Notificacion notificacion = db.Notificacion.Find(id);
            if (notificacion == null)
            {
                return NotFound();
            }

            return Ok(notificacion);
        }

        // PUT: api/Notificacions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNotificacion(int id, Notificacion notificacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != notificacion.Id)
            {
                return BadRequest();
            }

            db.Entry(notificacion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotificacionExists(id))
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

        // POST: api/Notificacions
        [ResponseType(typeof(Notificacion))]
        public IHttpActionResult PostNotificacion(Notificacion notificacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Notificacion.Add(notificacion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = notificacion.Id }, notificacion);
        }

        // DELETE: api/Notificacions/5
        [ResponseType(typeof(Notificacion))]
        public IHttpActionResult DeleteNotificacion(int id)
        {
            Notificacion notificacion = db.Notificacion.Find(id);
            if (notificacion == null)
            {
                return NotFound();
            }

            db.Notificacion.Remove(notificacion);
            db.SaveChanges();

            return Ok(notificacion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NotificacionExists(int id)
        {
            return db.Notificacion.Count(e => e.Id == id) > 0;
        }
    }
}