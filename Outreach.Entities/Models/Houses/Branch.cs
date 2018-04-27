using Outreach.Entities.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.Branches
{
    public class Branch
    {
        
        public int BranchId { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int HouseId { get; set; }
        public int StaffId { get; set; }
       

    }
}