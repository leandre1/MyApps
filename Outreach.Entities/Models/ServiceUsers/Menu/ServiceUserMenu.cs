using Outreach.Entities.ServiceUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.Models.ServiceUsers.Menu
{
    public class ServiceUserMenu
    {
        public int ServiceUserMenuId { get; set; }
        public int ServiceUserId { get; set; }
        public int MenuId { get; set; }
        public string Description { get; set; }
    }
}