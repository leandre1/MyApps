using Outreach.Entities.Models.ServiceUsers.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.ViewModels.ServiceUserViewModels
{
    public class ServiceUserMenuVM
    {
        public ServiceUserMenu UserMenu { get; set; }
        public List<ServiceUserMedicalAppointmentVM> Appointment { get; set; }
        //public Menu ItemMenu { get; set; }
    }
}