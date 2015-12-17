using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using QwiMis.interfaces;
using QWI.Models.dbmodels;
using Microsoft.Data.Entity.Storage;

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

        public IActionResult Index()
        {
            
            IEnumerable<accountgroup> accountgroups= _iaccountgroupservice.getallaccountgroups();
            return View(accountgroups);
        }
    }
}
