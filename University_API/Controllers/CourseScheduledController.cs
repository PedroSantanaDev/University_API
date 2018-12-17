using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using University_API.Models;

namespace University_API.Controllers
{
    public class CourseScheduledController : ApiController
    {
        private UniversityContext db = new UniversityContext();

        // GET: api/CourseScheduled
        public IQueryable<CourseScheduled> GetCourseScheduleds()
        {
            return db.CourseScheduleds;
        }

        // GET: api/CourseScheduled/5
        [ResponseType(typeof(CourseScheduled))]
        public async Task<IHttpActionResult> GetCourseScheduled(int id)
        {
            CourseScheduled courseScheduled = await db.CourseScheduleds.FindAsync(id);
            if (courseScheduled == null)
            {
                return NotFound();
            }

            return Ok(courseScheduled);
        }

        // PUT: api/CourseScheduled/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCourseScheduled(int id, CourseScheduled courseScheduled)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != courseScheduled.CourseScheduledId)
            {
                return BadRequest();
            }

            db.Entry(courseScheduled).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseScheduledExists(id))
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

        // POST: api/CourseScheduled
        [ResponseType(typeof(CourseScheduled))]
        public async Task<IHttpActionResult> PostCourseScheduled(CourseScheduled courseScheduled)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CourseScheduleds.Add(courseScheduled);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = courseScheduled.CourseScheduledId }, courseScheduled);
        }

        // DELETE: api/CourseScheduled/5
        [ResponseType(typeof(CourseScheduled))]
        public async Task<IHttpActionResult> DeleteCourseScheduled(int id)
        {
            CourseScheduled courseScheduled = await db.CourseScheduleds.FindAsync(id);
            if (courseScheduled == null)
            {
                return NotFound();
            }

            db.CourseScheduleds.Remove(courseScheduled);
            await db.SaveChangesAsync();

            return Ok(courseScheduled);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CourseScheduledExists(int id)
        {
            return db.CourseScheduleds.Count(e => e.CourseScheduledId == id) > 0;
        }
    }
}