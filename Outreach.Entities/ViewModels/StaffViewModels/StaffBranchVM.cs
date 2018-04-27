using Outreach.Entities.Branches;
using Outreach.Entities.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.ViewModels.StaffViewModels
{
    public class StaffBranchVM
    {
        public Staff Staff { get; set; }
        public Branch Branch { get; set; }
    }
}