using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using QWI.Models.dbmodels;
using QwiMis.Models;

namespace QwiMis.Controllers
{
    public class products1Controller : Controller
    {
        private ApplicationDbContext _context;

        public products1Controller(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: products1
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.products.Include(p => p.productcategory).Include(p => p.producttype);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: products1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            products products = await _context.products.SingleAsync(m => m.productid == id);
            if (products == null)
            {
                return HttpNotFound();
            }

            return View(products);
        }

        // GET: products1/Create
        public IActionResult Create()
        {
            ViewBag.productcategoryid = new SelectList(_context.productcategory, "productcategoryid", "productcategory");
            ViewBag.producttypeid = new SelectList(_context.producttype, "producttypeid", "producttype");
            return View();
        }

        // POST: products1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(products products)
        {
            if (ModelState.IsValid)
            {
                _context.products.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["productcategoryid"] = new SelectList(_context.productcategory, "productcategoryid", "productcategory", products.productcategoryid);
            ViewData["producttypeid"] = new SelectList(_context.producttype, "producttypeid", "producttype", products.producttypeid);
            return View(products);
        }

        // GET: products1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            products products = await _context.products.SingleAsync(m => m.productid == id);
            if (products == null)
            {
                return HttpNotFound();
            }
            ViewData["productcategoryid"] = new SelectList(_context.productcategory, "productcategoryid", "productcategory", products.productcategoryid);
            ViewData["producttypeid"] = new SelectList(_context.producttype, "producttypeid", "producttype", products.producttypeid);
            return View(products);
        }

        // POST: products1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(products products)
        {
            if (ModelState.IsValid)
            {
                _context.Update(products);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["productcategoryid"] = new SelectList(_context.productcategory, "productcategoryid", "productcategory", products.productcategoryid);
            ViewData["producttypeid"] = new SelectList(_context.producttype, "producttypeid", "producttype", products.producttypeid);
            return View(products);
        }

        // GET: products1/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            products products = await _context.products.SingleAsync(m => m.productid == id);
            if (products == null)
            {
                return HttpNotFound();
            }

            return View(products);
        }

        // POST: products1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            products products = await _context.products.SingleAsync(m => m.productid == id);
            _context.products.Remove(products);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
