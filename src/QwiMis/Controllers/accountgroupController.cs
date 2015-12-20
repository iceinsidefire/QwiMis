using Microsoft.AspNet.Mvc;
using QWI.Models.dbmodels;
using QwiMis.interfaces;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace QwiMis.Controllers
{
    public class accountgroupController : Controller

    {
        // GET: /<controller>/

        private Iaccountgroupservice _iaccountgroupservice;

        public accountgroupController(Iaccountgroupservice accountservice)
        {
            _iaccountgroupservice = accountservice;
        }

        public async Task<IActionResult> Index()
        {
            var accountgroups = await _iaccountgroupservice.getall();
            return View(accountgroups);
        }

        public async Task<IActionResult> Details(int id)
        {
            accountgroup accountgroups = await _iaccountgroupservice.first(x => x.accountgroupid == id);
            return View(accountgroups);
        }
    }
}