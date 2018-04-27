
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Outreach.Entities.Doctors;

namespace Outreach.Entities.ServiceUsers
{
    public class ServiceUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public byte DoctorId { get; set; }
        public byte StaffId { get; set; }
        public int BranchId { get; set; }
        public string ImageUrl { get; set; }

    }
}