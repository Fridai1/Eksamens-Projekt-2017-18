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
using RESTfulWebServiceProject;

namespace RESTfulWebServiceProject.Controllers
{
    public class EducationSitesController : ApiController
    {
        private TouchPointDBContext db = new TouchPointDBContext();

        // GET: api/EducationSites
        public IQueryable<EducationSites> GetEducationSites()
        {
            return db.EducationSites;
        }

        // GET: api/EducationSites/5
        [ResponseType(typeof(EducationSites))]
        public IHttpActionResult GetEducationSites(string id)
        {
            EducationSites educationSites = db.EducationSites.Find(id);
            if (educationSites == null)
            {
                return NotFound();
            }

            return Ok(educationSites);
        }

        // PUT: api/EducationSites/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEducationSites(string id, EducationSites educationSites)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != educationSites.Name)
            {
                return BadRequest();
            }

            db.Entry(educationSites).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationSitesExists(id))
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

        // POST: api/EducationSites
        [ResponseType(typeof(EducationSites))]
        public IHttpActionResult PostEducationSites(EducationSites educationSites)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EducationSites.Add(educationSites);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (EducationSitesExists(educationSites.Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = educationSites.Name }, educationSites);
        }

        // DELETE: api/EducationSites/5
        [ResponseType(typeof(EducationSites))]
        public IHttpActionResult DeleteEducationSites(string id)
        {
            EducationSites educationSites = db.EducationSites.Find(id);
            if (educationSites == null)
            {
                return NotFound();
            }

            db.EducationSites.Remove(educationSites);
            db.SaveChanges();

            return Ok(educationSites);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EducationSitesExists(string id)
        {
            return db.EducationSites.Count(e => e.Name == id) > 0;
        }
    }
}