using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.Models.ServiceUsers.Menu
{
    public class PopulatedStaffStandardMenu
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int MenuId { get; set; }
        public string Description { get; set; }
    }
}