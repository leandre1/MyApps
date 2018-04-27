using Outreach.Entities.Branches;
using Outreach.Entities.Models.Staffs.Menu;
using Outreach.Entities.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.ViewModels.StaffViewModels
{
    public class StaffProfileVM
    {
        public StaffBranchVM StaffBranchVM{ get; set; }
        public List<StaffStandardMenu> StaffStandardMenus { get; set; }
        

    }
}