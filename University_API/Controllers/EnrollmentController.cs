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
    public class EnrollmentController : ApiController
    {
        private UniversityContext db = new UniversityContext();

        // GET: api/Enrollment
        public IQueryable<Enrollment> GetEnrollments()
        {
            return db.Enrollments;
        }

        // GET: api/Enrollment/5
        [ResponseType(typeof(Enrollment))]
        public async Task<IHttpActionResult> GetEnrollment(int id)
        {
            Enrollment enrollment = await db.Enrollments.FindAsync(id);
            if (enrollment == null)
            {
                return NotFound();
            }

            return Ok(enrollment);
        }

        // PUT: api/Enrollment/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEnrollment(int id, Enrollment enrollment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != enrollment.EnrollmentId)
            {
                return BadRequest();
            }

            db.Entry(enrollment).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnrollmentExists(id))
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

        // POST: api/Enrollment
        [ResponseType(typeof(Enrollment))]
        public async Task<IHttpActionResult> PostEnrollment(Enrollment enrollment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Enrollments.Add(enrollment);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = enrollment.EnrollmentId }, enrollment);
        }

        // DELETE: api/Enrollment/5
        [ResponseType(typeof(Enrollment))]
        public async Task<IHttpActionResult> DeleteEnrollment(int id)
        {
            Enrollment enrollment = await db.Enrollments.FindAsync(id);
            if (enrollment == null)
            {
                return NotFound();
            }

            db.Enrollments.Remove(enrollment);
            await db.SaveChangesAsync();

            return Ok(enrollment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EnrollmentExists(int id)
        {
            return db.Enrollments.Count(e => e.EnrollmentId == id) > 0;
        }
    }
}