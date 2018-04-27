using Outreach.Data.Repository;
using Outreach.Entities.Models.ServiceUsers.Menu;
using Outreach.Entities.ViewModels.ServiceUserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Outreach.Web.Controllers
{
    public class ServiceUserMenuController : Controller
    {
        // GET: ServiceUserMenu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplayViewMenu(int id)
        {
            var repoServiceUserMenu = new ServiceUserMenuRepository().GetAll().ToList();

            int serviceUserId = (int)Session["userId"];

            ServiceUserMenu userMenu  = repoServiceUserMenu.FirstOrDefault(s => s.MenuId == id && s.ServiceUserId == serviceUserId);
            var viewModel = new ServiceUserMenuVM { UserMenu = userMenu };
            if(userMenu.MenuId == 1)
                return PartialView("_Background", viewModel);
            return new EmptyResult();
        }
       
    }
}