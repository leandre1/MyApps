using Outreach.Entities.Branches;
using Outreach.Entities.ServiceUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.ViewModels.ServiceUserViewModels
{
    public class ServiceUserIndexVM
    {
        public ServiceUser serviceUser { get; set; }
        public Branch branch { get; set; }
    }
}