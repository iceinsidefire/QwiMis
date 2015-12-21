using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using QWI.Models.dbmodels;
using QwiMis.Models;

namespace QwiMis.Controllers
{
    public class coils_wirerodController : Controller
    {
        private ApplicationDbContext _context;

        public coils_wirerodController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: coils_wirerod
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.coils_wirerod.Include(c => c.gatein);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: coils_wirerod/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            coils_wirerod coils_wirerod = await _context.coils_wirerod.SingleAsync(m => m.coilnumber == id);
            if (coils_wirerod == null)
            {
                return HttpNotFound();
            }

            return View(coils_wirerod);
        }

        // GET: coils_wirerod/Create
        public IActionResult Create()
        {
            ViewData["gateinid"] = new SelectList(_context.gatein, "gateinid", "gatein");
            return View();
        }

        // POST: coils_wirerod/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(coils_wirerod coils_wirerod)
        {
            if (ModelState.IsValid)
            {
                _context.coils_wirerod.Add(coils_wirerod);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["gateinid"] = new SelectList(_context.gatein, "gateinid", "gatein", coils_wirerod.gateinid);
            return View(coils_wirerod);
        }

        // GET: coils_wirerod/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            coils_wirerod coils_wirerod = await _context.coils_wirerod.SingleAsync(m => m.coilnumber == id);
            if (coils_wirerod == null)
            {
                return HttpNotFound();
            }
            ViewData["gateinid"] = new SelectList(_context.gatein, "gateinid", "gatein", coils_wirerod.gateinid);
            return View(coils_wirerod);
        }

        // POST: coils_wirerod/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(coils_wirerod coils_wirerod)
        {
            if (ModelState.IsValid)
            {
                _context.Update(coils_wirerod);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["gateinid"] = new SelectList(_context.gatein, "gateinid", "gatein", coils_wirerod.gateinid);
            return View(coils_wirerod);
        }

        // GET: coils_wirerod/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            coils_wirerod coils_wirerod = await _context.coils_wirerod.SingleAsync(m => m.coilnumber == id);
            if (coils_wirerod == null)
            {
                return HttpNotFound();
            }

            return View(coils_wirerod);
        }

        // POST: coils_wirerod/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            coils_wirerod coils_wirerod = await _context.coils_wirerod.SingleAsync(m => m.coilnumber == id);
            _context.coils_wirerod.Remove(coils_wirerod);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
