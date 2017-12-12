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
using RESTfulServiceProject;

namespace RESTfulServiceProject.Controllers
{
    public class RoomsController : ApiController
    {
        private TouchPointDBContext db = new TouchPointDBContext();

        // GET: api/Rooms
        public IQueryable<Rooms> GetRooms()
        {
            return db.Rooms;
        }

        // GET: api/Rooms/5
        [ResponseType(typeof(Rooms))]
        public IHttpActionResult GetRooms(int id)
        {
            Rooms rooms = db.Rooms.Find(id);
            if (rooms == null)
            {
                return NotFound();
            }

            return Ok(rooms);
        }

        // PUT: api/Rooms/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRooms(int id, Rooms rooms)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rooms.Id)
            {
                return BadRequest();
            }

            db.Entry(rooms).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomsExists(id))
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

        // POST: api/Rooms
        [ResponseType(typeof(Rooms))]
        public IHttpActionResult PostRooms(Rooms rooms)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rooms.Add(rooms);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (RoomsExists(rooms.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = rooms.Id }, rooms);
        }

        // DELETE: api/Rooms/5
        [ResponseType(typeof(Rooms))]
        public IHttpActionResult DeleteRooms(int id)
        {
            Rooms rooms = db.Rooms.Find(id);
            if (rooms == null)
            {
                return NotFound();
            }

            db.Rooms.Remove(rooms);
            db.SaveChanges();

            return Ok(rooms);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RoomsExists(int id)
        {
            return db.Rooms.Count(e => e.Id == id) > 0;
        }
    }
}