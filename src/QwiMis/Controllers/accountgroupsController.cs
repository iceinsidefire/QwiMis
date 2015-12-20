using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using QWI.Models.dbmodels;
using QwiMis.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwiMis.Controllers
{
    [Produces("application/json")]
    [Route("api/accountgroups")]
    public class accountgroupsController : Controller
    {
        private ApplicationDbContext _context;

        public accountgroupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/accountgroups
        [HttpGet]
        public IEnumerable<accountgroup> Getaccountgroup()
        {
            return _context.accountgroup;
        }

        // GET: api/accountgroups/5
        [HttpGet("{id}", Name = "Getaccountgroup")]
        public async Task<IActionResult> Getaccountgroup([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            accountgroup accountgroup = await _context.accountgroup.SingleAsync(m => m.accountgroupid == id);

            if (accountgroup == null)
            {
                return HttpNotFound();
            }

            return Ok(accountgroup);
        }

        // PUT: api/accountgroups/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putaccountgroup([FromRoute] int id, [FromBody] accountgroup accountgroup)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            if (id != accountgroup.accountgroupid)
            {
                return HttpBadRequest();
            }

            _context.Entry(accountgroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!accountgroupExists(id))
                {
                    return HttpNotFound();
                }
                else
                {
                    throw;
                }
            }

            return new HttpStatusCodeResult(StatusCodes.Status204NoContent);
        }

        // POST: api/accountgroups
        [HttpPost]
        public async Task<IActionResult> Postaccountgroup([FromBody] accountgroup accountgroup)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            _context.accountgroup.Add(accountgroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (accountgroupExists(accountgroup.accountgroupid))
                {
                    return new HttpStatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("Getaccountgroup", new { id = accountgroup.accountgroupid }, accountgroup);
        }

        // DELETE: api/accountgroups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteaccountgroup([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            accountgroup accountgroup = await _context.accountgroup.SingleAsync(m => m.accountgroupid == id);
            if (accountgroup == null)
            {
                return HttpNotFound();
            }

            _context.accountgroup.Remove(accountgroup);
            await _context.SaveChangesAsync();

            return Ok(accountgroup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool accountgroupExists(int id)
        {
            return _context.accountgroup.Count(e => e.accountgroupid == id) > 0;
        }
    }
}