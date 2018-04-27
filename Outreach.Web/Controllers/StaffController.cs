using Outreach.Data.Repository;
using Outreach.Entities.Branches;
using Outreach.Entities.Models.ServiceUsers.Menu;
using Outreach.Entities.Models.Staffs.Menu;
using Outreach.Entities.Staffs;
using Outreach.Entities.ViewModels.StaffViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Outreach.Web.Controllers
{
    public class StaffController : Controller
    {
        List<Staff> repoStaff = new StaffRepository().GetAll().ToList();
        List<Branch> repoBranch = new BranchRepository().GetAll().ToList();
        List<StaffStandardMenu> repoStaffStandardMenu = new StaffStandardMenuRepository().GetAll().ToList();
        List<PopulatedStaffStandardMenu> repoPopulatedStaffStandard = new PopulatedStaffStandardMenuRepository().GetAll().ToList();
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            var data = (from s in repoStaff
                        join b in repoBranch on s.BranchId equals b.BranchId
                        select new StaffBranchVM { Branch = b, Staff = s }).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);

        }
        public ActionResult ShowProfile(int Id)
        {
            Staff staff = repoStaff.SingleOrDefault(x => x.StaffId == Id);

            Branch branch = GetBranch(staff);
            var staffBranchVM = new StaffBranchVM { Branch = branch, Staff = staff };
    
            var vm = new StaffProfileVM
            {
                 StaffBranchVM = staffBranchVM,
                StaffStandardMenus = repoStaffStandardMenu
            };
            return View("Profile", vm);
        }
        private Branch GetBranch(Staff staff)
        {
            return (from s in repoStaff
                    join b in repoBranch on s.BranchId equals b.BranchId
                    select b).FirstOrDefault(x => x.BranchId == staff.BranchId);
        }
        
    }
}