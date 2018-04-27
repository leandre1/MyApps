using Outreach.Common.Interfaces;
using Outreach.Data.Repository;
using Outreach.Entities.Branches;
using Outreach.Entities.Houses;
using Outreach.Entities.HouseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Outreach.Web.Controllers
{
    public class BranchController : Controller
    {
        private readonly IRepository<Branch> _repoBranch;
        private readonly IRepository<House> _repoHouse;
        public BranchController(IRepository<Branch> repo,IRepository<House> repoHouse)
        {
            this._repoBranch = repo;
            this._repoHouse = repoHouse;
        }

        // GET: Branch
        public ActionResult Index()
        {
        //    var repoBranch = new BranchRepository().GetAll().ToList();
        //    var repoHouse = new HouseRepository().GetAll().ToList();
        //    var viewModel = (from h in repoHouse
        //                     join b in repoBranch on h.HouseId equals b.HouseId into bh
        //                     from b in bh.DefaultIfEmpty()
        //                     select new HouseDisplayModel() { Branch = b, House = h }).ToList();


            
            return View();
        }
        public JsonResult GetBranchData()
        {
            
            List<HouseDisplayModel> houses = (from h in _repoHouse.GetAll().ToList()
                                              join b in _repoBranch.GetAll().ToList() on h.HouseId equals b.HouseId into bh
                             from b in bh.DefaultIfEmpty()
                             select new HouseDisplayModel() {
                                  Branch = b,

                                 House = h }).ToList();
            return Json(houses, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult PopupModal()
        {
            var repo = _repoHouse.GetAll().ToList();
            var viewModal = new BranchFormModel {  Houses = repo};
            return PartialView("_BranchForm", viewModal);
        }
        public ActionResult Create(Branch branch)
        {
            var repo = _repoHouse.GetAll().ToList();

            var viewModel = new BranchFormModel { Branch = branch, Houses = repo };
            return View("_BranchForm", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Branch branch)
        {
            if (branch.BranchId == 0)
            {
                _repoBranch.Create(branch);
            }
            else
            {
                _repoBranch.Update( branch);
            }
            return RedirectToAction("Index", "Branch");
        }
        public ActionResult Edit(int id)
        {
            var viewModel = new BranchFormModel();
            if (id < 0)
                throw new ArgumentException("Invalid input!");
            else
            {
               Branch b = _repoBranch.Edit(id);
                viewModel.Branch = b;
                viewModel.Houses = _repoHouse.GetAll().ToList();
                
            }
            return View("BranchForm", viewModel);
            
        }
        
    }
}