using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using QWI.Models.dbmodels;
using QwiMis.Models;
using System.Threading.Tasks;

namespace QwiMis.Controllers
{
    public class accountgroups1Controller : Controller
    {
        private ApplicationDbContext _context;

        public accountgroups1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: accountgroups1
        public async Task<IActionResult> Index()
        {
            return View(await _context.accountgroup.ToListAsync());
        }

        // GET: accountgroups1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            accountgroup accountgroup = await _context.accountgroup.SingleAsync(m => m.accountgroupid == id);
            if (accountgroup == null)
            {
                return HttpNotFound();
            }

            return View(accountgroup);
        }

        // GET: accountgroups1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: accountgroups1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(accountgroup accountgroup)
        {
            if (ModelState.IsValid)
            {
                _context.accountgroup.Add(accountgroup);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(accountgroup);
        }

        // GET: accountgroups1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            accountgroup accountgroup = await _context.accountgroup.SingleAsync(m => m.accountgroupid == id);
            if (accountgroup == null)
            {
                return HttpNotFound();
            }
            return View(accountgroup);
        }

        // POST: accountgroups1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(accountgroup accountgroup)
        {
            if (ModelState.IsValid)
            {
                _context.Update(accountgroup);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(accountgroup);
        }

        // GET: accountgroups1/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            accountgroup accountgroup = await _context.accountgroup.SingleAsync(m => m.accountgroupid == id);
            if (accountgroup == null)
            {
                return HttpNotFound();
            }

            return View(accountgroup);
        }

        // POST: accountgroups1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            accountgroup accountgroup = await _context.accountgroup.SingleAsync(m => m.accountgroupid == id);
            _context.accountgroup.Remove(accountgroup);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}