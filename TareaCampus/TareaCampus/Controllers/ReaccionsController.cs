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
    public class ReaccionsController : ApiController
    {
        private DBContextProject db = new DBContextProject();

        // GET: api/Reaccions
        public IQueryable<Reaccion> GetReaccion()
        {
            return db.Reaccion;
        }

        // GET: api/Reaccions/5
        [ResponseType(typeof(Reaccion))]
        public IHttpActionResult GetReaccion(int id)
        {
            Reaccion reaccion = db.Reaccion.Find(id);
            if (reaccion == null)
            {
                return NotFound();
            }

            return Ok(reaccion);
        }

        // PUT: api/Reaccions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReaccion(int id, Reaccion reaccion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != reaccion.Id)
            {
                return BadRequest();
            }

            db.Entry(reaccion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReaccionExists(id))
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

        // POST: api/Reaccions
        [ResponseType(typeof(Reaccion))]
        public IHttpActionResult PostReaccion(Reaccion reaccion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Reaccion.Add(reaccion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = reaccion.Id }, reaccion);
        }

        // DELETE: api/Reaccions/5
        [ResponseType(typeof(Reaccion))]
        public IHttpActionResult DeleteReaccion(int id)
        {
            Reaccion reaccion = db.Reaccion.Find(id);
            if (reaccion == null)
            {
                return NotFound();
            }

            db.Reaccion.Remove(reaccion);
            db.SaveChanges();

            return Ok(reaccion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReaccionExists(int id)
        {
            return db.Reaccion.Count(e => e.Id == id) > 0;
        }
    }
}