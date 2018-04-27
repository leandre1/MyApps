using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.Models.ServiceUsers.Appointment
{
    public class MedicalAppointment
    {
        public int Id { get; set; }
        public int ServiceUserId { get; set; }
        public int DoctorId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string Reason { get; set; }
    }
}