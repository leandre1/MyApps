using Outreach.Entities.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.ViewModels.ServiceUserFormVM
{
    public class ServiceUserFormVM
    {
        public Staff Keyworker { get; set; }
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int id { get; set; }
    }
}