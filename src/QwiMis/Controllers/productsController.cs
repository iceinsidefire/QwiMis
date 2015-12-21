using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using QWI.Models.dbmodels;
using QwiMis.Models;
using QwiMis.interfaces;
using System;
using Microsoft.Extensions.DependencyInjection;
using QwiMis.Services;

namespace QwiMis.Controllers
{
    public class productsController : Controller
    {
        private service_products _productservice;
        private ApplicationDbContext _context;

        public productsController( IServiceProvider serviceProvider)
        {
            _productservice = new service_products(serviceProvider);
            _context = serviceProvider.GetService<ApplicationDbContext>();
        }

        // GET: products1
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _productservice.getallproducts_with_type();
            return View(await applicationDbContext);
        }

        // GET: products1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            products products = await _productservice.singleasync(m => m.productid == id);
            if (products == null)
            {
                return HttpNotFound();
            }

            return View(products);
        }

        // GET: products1/Create
        public IActionResult Create()
        {
            ViewData["procat"] = new SelectList(_context.productcategory, "productcategoryid", "categoryname");
            ViewBag["protype"] = new SelectList(_context.producttype, "producttypeid", "typename");
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
            ViewData["productcategoryid"] = new SelectList(_context.productcategory, "productcategoryid", "categoryname", products.productcategoryid);
            ViewData["producttypeid"] = new SelectList(_context.producttype, "producttypeid", "typename", products.producttypeid);
            return View(products);
        }

        // GET: products1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            products products = await _productservice.singleasync(m => m.productid == id);
            if (products == null)
            {
                return HttpNotFound();
            }
            ViewData["productcategoryid"] = new SelectList(_context.productcategory, "productcategoryid","categoryname", products.productcategoryid);
            ViewData["producttypeid"] = new SelectList(_context.producttype, "producttypeid", "typename", products.producttypeid);
            return View(products);
        }

        // POST: products1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(products products)
        {
            if (ModelState.IsValid)
            {
                _productservice.update(products);
                await _productservice.savechangesasync();
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

            products products = await _productservice.singleasync(m => m.productid == id);
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
            products products = await _productservice.singleasync(m => m.productid == id);
            _productservice.remove(products);
            await _productservice.savechangesasync();
            return RedirectToAction("Index");
        }
    }
}
