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
using EntityFrameworkProject;

namespace EntityFrameworkProject.Controllers
{
    public class EducationSitesController : ApiController
    {
        private TouchpointDBContext db = new TouchpointDBContext();

        // GET: api/EducationSites
        public IQueryable<EducationSite> GetEducationSites()
        {
            return db.EducationSites;
        }

        // GET: api/EducationSites/5
        [ResponseType(typeof(EducationSite))]
        public IHttpActionResult GetEducationSite(string id)
        {
            EducationSite educationSite = db.EducationSites.Find(id);
            if (educationSite == null)
            {
                return NotFound();
            }

            return Ok(educationSite);
        }

        // PUT: api/EducationSites/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEducationSite(string id, EducationSite educationSite)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != educationSite.EduSiteName)
            {
                return BadRequest();
            }

            db.Entry(educationSite).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationSiteExists(id))
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
        [ResponseType(typeof(EducationSite))]
        public IHttpActionResult PostEducationSite(EducationSite educationSite)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EducationSites.Add(educationSite);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (EducationSiteExists(educationSite.EduSiteName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = educationSite.EduSiteName }, educationSite);
        }

        // DELETE: api/EducationSites/5
        [ResponseType(typeof(EducationSite))]
        public IHttpActionResult DeleteEducationSite(string id)
        {
            EducationSite educationSite = db.EducationSites.Find(id);
            if (educationSite == null)
            {
                return NotFound();
            }

            db.EducationSites.Remove(educationSite);
            db.SaveChanges();

            return Ok(educationSite);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EducationSiteExists(string id)
        {
            return db.EducationSites.Count(e => e.EduSiteName == id) > 0;
        }
    }
}