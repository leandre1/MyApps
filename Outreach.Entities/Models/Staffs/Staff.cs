using Outreach.Entities.Branches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.Staffs
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfRegistration { get; set; }
        public string ImageUrl { get; set; }
        public int BranchId { get; set; }
    }
}