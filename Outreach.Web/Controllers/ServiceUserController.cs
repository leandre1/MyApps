using Outreach.Common.Interfaces;
using Outreach.Data.Repository;
using Outreach.Entities.Branches;
using Outreach.Entities.Doctors;
using Outreach.Entities.Models.ServiceUsers.Appointment;
using Outreach.Entities.Models.ServiceUsers.Menu;
using Outreach.Entities.ServiceUsers;
using Outreach.Entities.Staffs;
using Outreach.Entities.ViewModels.ServiceUserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Outreach.Web.Controllers
{
    public class ServiceUserController : Controller
    {
        private readonly IRepository<Staff> _staffRepo;
        private readonly IRepository<ServiceUserMenu> _serviceUserMenuRepo;
        private readonly IRepository<ServiceUser> _serviceUserRepo;
        private readonly IRepository<Branch> _branchRepo;
        private readonly IRepository<MedicalAppointment> _medicalAppointmentRepo;
        private readonly IRepository<Doctor> _doctorRepo;
        private readonly IRepository<Menu> _menuRepo;

        public ServiceUserController(IRepository<Staff> staffRepo,
            IRepository<ServiceUserMenu> serviceUserMenuRepo,
            IRepository<ServiceUser> serviceUserRepo,
            IRepository<Branch> branchRepo,
            IRepository<MedicalAppointment> medicalAppointmentRepo,
            IRepository<Doctor> doctorRepo,
            IRepository<Menu> menuRepo)
        {
            _staffRepo = staffRepo;
            _serviceUserMenuRepo = serviceUserMenuRepo;
            _serviceUserRepo = serviceUserRepo;
            _branchRepo = branchRepo;
            _medicalAppointmentRepo = medicalAppointmentRepo;
            _doctorRepo = doctorRepo;
            _menuRepo = menuRepo;
        }
        // GET: ServiceUser
        public ActionResult Index()
        {
            //var repoServiceUser = new ServiceUserRepository().GetAll().ToList();
            //var repoBranch = new BranchRepository().GetAll().ToList();
            //var viewModel = (from s in repoServiceUser
            //                 join b in repoBranch on s.BranchId equals b.BranchId 
            //                select new ServiceUserIndexVM() { branch = b, serviceUser = s }).ToList();
            var vm = GetServiceUserBranch();
            return View("Index", vm);
        }
        
        public JsonResult GetStaff(string term)
        {
            term = Request.QueryString["search"];
            var repo = _staffRepo.GetAll()
                .Where(x => term == null || x.FirstName.ToUpper().Contains(term.ToUpper()))
                .Select(x => new { Id = x.StaffId, Name = x.FirstName + " " + x.LastName }).Distinct()
                .ToList();
            return Json(repo, JsonRequestBehavior.AllowGet);

        }
        public ActionResult ShowProfile(int id)
        {
            var vm = GetServiceUserBranch();

            ServiceUser serviceUser = vm.FirstOrDefault(s => s.serviceUser.Id == id).serviceUser;
            Branch branch = vm.FirstOrDefault(b => b.serviceUser.BranchId == serviceUser.BranchId).branch;

            var menu = _menuRepo.GetAll().ToList();

            var viewModel = new ServiceUserProfile();
            if (serviceUser != null)
            {
                viewModel.serviceUser = serviceUser;
                viewModel.branch = branch;
                viewModel.UserMenu = menu;
                //viewModel.UserMenuDescription = userMenuDescr;

                Session["userId"] = serviceUser.Id;

            }
            else { return new HttpNotFoundResult("Not Found"); }

            return View("Profile", viewModel);
        }

        private List<ServiceUserIndexVM> GetServiceUserBranch()
        {
            var repoServiceUser = _serviceUserRepo.GetAll().ToList();
            var repoBranch = _branchRepo.GetAll().ToList();
            var viewModel = (from s in repoServiceUser
                             join b in repoBranch on s.BranchId equals b.BranchId
                             select new ServiceUserIndexVM() { branch = b, serviceUser = s }).ToList();
            return viewModel;
        }

        public ActionResult DisplayViewMenu(int id)
        {
            var repoServiceUserMenu = _serviceUserMenuRepo.GetAll().ToList();

            int serviceUserId = (int)Session["userId"];

            ServiceUserMenu userMenuDescr = repoServiceUserMenu.FirstOrDefault(s => s.MenuId == id && s.ServiceUserId == serviceUserId);
            GetMedicalAppointmentData(serviceUserId);
            var vm = new ServiceUserMenuVM
            {
                UserMenu = userMenuDescr,
                Appointment = GetMedicalAppointmentData(serviceUserId)

        };
            var menu = new Menu();
            switch (id)
            {
                case 1:
                    return PartialView("_Background", vm);

                case 2:
                    return PartialView("_Health", vm);
                case 3:
                    return PartialView("_FoodMenu", vm);
                case 4:
                    return PartialView("_FamilySocial", vm);
                case 5:
                    return PartialView("_Activities", vm);
            }

            return new EmptyResult();

        }
        public List<ServiceUserMedicalAppointmentVM> GetMedicalAppointmentData(int id)
        {
            var repoMedicalAppointment = _medicalAppointmentRepo.GetAll().ToList();
            var repoServiceUser = _serviceUserRepo.GetAll().ToList();
            var repoDoctor = _doctorRepo.GetAll().ToList();
            var data = (from s in repoServiceUser
                        join m in repoMedicalAppointment on s.Id equals m.ServiceUserId
                        join d in repoDoctor on m.DoctorId equals d.DoctorId
                        where id == s.Id
                        select new ServiceUserMedicalAppointmentVM { ServiceUser = s, Doctor = d, HealthAppointment = m }).ToList();
            return data;
        }
    }
}