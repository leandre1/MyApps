using Dapper;
using Outreach.Common.Interfaces;
using Outreach.Entities.Models.ServiceUsers.Appointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Data.Repository
{
    public class MedicalAppointmentRepository : ConnectToDb, IRepository<MedicalAppointment>
    {
        public void Create(MedicalAppointment appointment)
        {
            throw new NotImplementedException();
        }

        public MedicalAppointment Edit(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MedicalAppointment> GetAll()
        {
            return db.Query<MedicalAppointment>("Select * from MedicalAppointment");
        }

        public void Update(MedicalAppointment appointment)
        {
            throw new NotImplementedException();
        }
    }
}