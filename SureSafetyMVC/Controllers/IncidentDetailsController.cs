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
using SureSafetyDB;

namespace SureSafetyMVC.Controllers
{
    public class IncidentDetailsController : ApiController
    {
        private SureSafetyDBModelContainer db = new SureSafetyDBModelContainer();

        // GET: api/IncidentDetails
        public IQueryable<IncidentDetails> GetIncidentDetails()
        {
            return db.IncidentDetails;
        }

        // GET: api/IncidentDetails/5
        [ResponseType(typeof(IncidentDetails))]
        public IHttpActionResult GetIncidentDetails(int id)
        {
            IncidentDetails incidentDetails = db.IncidentDetails.Find(id);
            if (incidentDetails == null)
            {
                return NotFound();
            }

            return Ok(incidentDetails);
        }

        // PUT: api/IncidentDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutIncidentDetails(int id, IncidentDetails incidentDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != incidentDetails.Id)
            {
                return BadRequest();
            }

            db.Entry(incidentDetails).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncidentDetailsExists(id))
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

        // POST: api/IncidentDetails
        [ResponseType(typeof(IncidentDetails))]
        public IHttpActionResult PostIncidentDetails(IncidentDetails incidentDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.IncidentDetails.Add(incidentDetails);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = incidentDetails.Id }, incidentDetails);
        }

        // DELETE: api/IncidentDetails/5
        [ResponseType(typeof(IncidentDetails))]
        public IHttpActionResult DeleteIncidentDetails(int id)
        {
            IncidentDetails incidentDetails = db.IncidentDetails.Find(id);
            if (incidentDetails == null)
            {
                return NotFound();
            }

            db.IncidentDetails.Remove(incidentDetails);
            db.SaveChanges();

            return Ok(incidentDetails);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IncidentDetailsExists(int id)
        {
            return db.IncidentDetails.Count(e => e.Id == id) > 0;
        }
    }
}