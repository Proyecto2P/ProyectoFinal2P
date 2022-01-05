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
    public class ContinentesController : ApiController
    {
        private ModeloTuristeando db = new ModeloTuristeando();

        // GET: api/Continentes
        public IQueryable<Continentes> GetContinentes()
        {
            return db.Continentes;
        }

        // GET: api/Continentes/5
        [ResponseType(typeof(Continentes))]
        public IHttpActionResult GetContinentes(int id)
        {
            Continentes continentes = db.Continentes.Find(id);
            if (continentes == null)
            {
                return NotFound();
            }

            return Ok(continentes);
        }

        // PUT: api/Continentes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutContinentes(int id, Continentes continentes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != continentes.ContinenteID)
            {
                return BadRequest();
            }

            db.Entry(continentes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContinentesExists(id))
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

        // POST: api/Continentes
        [ResponseType(typeof(Continentes))]
        public IHttpActionResult PostContinentes(Continentes continentes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Continentes.Add(continentes);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = continentes.ContinenteID }, continentes);
        }

        // DELETE: api/Continentes/5
        [ResponseType(typeof(Continentes))]
        public IHttpActionResult DeleteContinentes(int id)
        {
            Continentes continentes = db.Continentes.Find(id);
            if (continentes == null)
            {
                return NotFound();
            }

            db.Continentes.Remove(continentes);
            db.SaveChanges();

            return Ok(continentes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContinentesExists(int id)
        {
            return db.Continentes.Count(e => e.ContinenteID == id) > 0;
        }
    }
}