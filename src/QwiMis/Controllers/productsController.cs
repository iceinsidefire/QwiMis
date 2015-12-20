using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using QWI.Models.dbmodels;
using QwiMis.Models;
using QwiMis.interfaces;
using System;

namespace QwiMis.Controllers
{
    public class productsController : Controller
    {
        private Iproductservice _productservice;
        private ApplicationDbContext _context;

        public productsController(Iproductservice productservice, IServiceProvider serviceProvider)
        {
            _productservice = productservice;  
            _context= serviceProvider.GetService<ApplicationDbContext>();
        }

        // GET: products
        public async Task<IActionResult> Index()
        {
            return View(await _productservice.getall());
        }

        // GET: products/Details/5
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

        // GET: products/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.productcategoryid =  new SelectList(_context.productcategory, "productcategoryid", "productcategory");
           // ViewData["producttypeid"] = new SelectList(_context.producttype, "producttypeid", "producttype");

            return View();
        }

        // POST: products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(products products)
        {
            if (ModelState.IsValid)
            {
                _productservice.add(products);
                await _productservice.savechangesasync();
                return RedirectToAction("Index");
            }
            return View(products);
        }

        // GET: products/Edit/5
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
            return View(products);
        }

        // POST: products/Edit/5
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
            return View(products);
        }

        // GET: products/Delete/5
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

        // POST: products/Delete/5
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
