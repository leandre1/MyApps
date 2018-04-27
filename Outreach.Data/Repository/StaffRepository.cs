using Dapper;
using Outreach.Common.Interfaces;
using Outreach.Entities.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Data.Repository
{
    public class StaffRepository : ConnectToDb, IRepository<Staff>
    {
        public void Create(Staff staff)
        {
            throw new NotImplementedException();
        }

        public Staff Edit(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Staff> GetAll()
        {
            return db.Query<Staff>("Select * from Staff").ToList();
        }

        public void Update(Staff branch)
        {
            throw new NotImplementedException();
        }
    }
}
    
