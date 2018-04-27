using Outreach.Entities.Models.ServiceUsers.Menu;
using Outreach.Entities.ServiceUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.ViewModels.ServiceUserViewModels
{
    public class ServiceUserProfile:ServiceUserIndexVM
    {
        public List<Menu> UserMenu{ get; set; }
        public List<ServiceUserMenu> UserMenuDescription { get; set; } 

    }
}