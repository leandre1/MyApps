using Outreach.Data.Repository;
using Outreach.Entities.Branches;
using Outreach.Entities.HouseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Outreach.Web.Controllers
{
    public class HouseController : Controller
    {
        // GET: House
        public ActionResult Index()
        {
            var repoBranch = new BranchRepository().GetAll().ToList();
            var repoHouse = new HouseRepository().GetAll().ToList();
            var viewModel = (from h in repoHouse
                            join b in repoBranch on h.HouseId equals b.HouseId into bh
                            from b in bh.DefaultIfEmpty()
                            select new HouseDisplayModel() { Branch = b, House = h }).ToList();

          
            return View(viewModel);
        }
        public ActionResult Edit(int id)
        {
           
                return RedirectToAction("Edit", "Branch");
            

        }
    }
}