using Dapper;
using Outreach.Common.Interfaces;
using Outreach.Entities.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Data.Repository
{
    public class DoctorRepository : ConnectToDb, IRepository<Doctor>
    {
        public void Create(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Doctor Edit(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> GetAll()
        {
            return db.Query<Doctor>("Select * from Doctor");
        }

        public void Update(Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}