using Outreach.Entities.Doctors;
using Outreach.Entities.Models.ServiceUsers.Appointment;
using Outreach.Entities.ServiceUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.ViewModels.ServiceUserViewModels
{
    public class ServiceUserMedicalAppointmentVM
    {
        public Doctor Doctor { get; set; }
        public ServiceUser ServiceUser { get; set; }
        public MedicalAppointment HealthAppointment { get; set; }
    }
}