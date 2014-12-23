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
using Kompliant.Model;
using Kompliant.Models;

namespace Kompliant.Controllers
{
    public class RequirementsController : ApiController
    {
        private KompliantContext db = new KompliantContext();

        // GET: api/Requirements
        public IQueryable<Requirement> GetRequirements()
        {
            return db.Requirements;
        }

        // GET: api/Requirements/5
        [ResponseType(typeof(Requirement))]
        public IHttpActionResult GetRequirement(int id)
        {
            Requirement requirement = db.Requirements.Find(id);
            if (requirement == null)
            {
                return NotFound();
            }

            return Ok(requirement);
        }

        // PUT: api/Requirements/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRequirement(int id, Requirement requirement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != requirement.Id)
            {
                return BadRequest();
            }

            db.Entry(requirement).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequirementExists(id))
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

        // POST: api/Requirements
        [ResponseType(typeof(Requirement))]
        public IHttpActionResult PostRequirement(Requirement requirement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Requirements.Add(requirement);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = requirement.Id }, requirement);
        }

        // DELETE: api/Requirements/5
        [ResponseType(typeof(Requirement))]
        public IHttpActionResult DeleteRequirement(int id)
        {
            Requirement requirement = db.Requirements.Find(id);
            if (requirement == null)
            {
                return NotFound();
            }

            db.Requirements.Remove(requirement);
            db.SaveChanges();

            return Ok(requirement);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RequirementExists(int id)
        {
            return db.Requirements.Count(e => e.Id == id) > 0;
        }
    }
}