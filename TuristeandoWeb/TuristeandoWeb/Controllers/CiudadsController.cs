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
using TuristeandoWeb.Models;

namespace TuristeandoWeb.Controllers
{
    public class CiudadsController : ApiController
    {
        private ModeloTuristeando db = new ModeloTuristeando();

        // GET: api/Ciudads
        public IQueryable<Ciudads> GetCiudads()
        {
            return db.Ciudads;
        }

        // GET: api/Ciudads/5
        [ResponseType(typeof(Ciudads))]
        public IHttpActionResult GetCiudads(int id)
        {
            Ciudads ciudads = db.Ciudads.Find(id);
            if (ciudads == null)
            {
                return NotFound();
            }

            return Ok(ciudads);
        }

        // PUT: api/Ciudads/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCiudads(int id, Ciudads ciudads)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ciudads.CiudadID)
            {
                return BadRequest();
            }

            db.Entry(ciudads).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CiudadsExists(id))
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

        // POST: api/Ciudads
        [ResponseType(typeof(Ciudads))]
        public IHttpActionResult PostCiudads(Ciudads ciudads)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ciudads.Add(ciudads);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ciudads.CiudadID }, ciudads);
        }

        // DELETE: api/Ciudads/5
        [ResponseType(typeof(Ciudads))]
        public IHttpActionResult DeleteCiudads(int id)
        {
            Ciudads ciudads = db.Ciudads.Find(id);
            if (ciudads == null)
            {
                return NotFound();
            }

            db.Ciudads.Remove(ciudads);
            db.SaveChanges();

            return Ok(ciudads);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CiudadsExists(int id)
        {
            return db.Ciudads.Count(e => e.CiudadID == id) > 0;
        }
    }
}