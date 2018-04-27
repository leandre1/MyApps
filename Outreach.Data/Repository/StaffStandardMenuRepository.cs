using Dapper;
using Outreach.Common.Interfaces;
using Outreach.Entities.Models.Staffs.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Data.Repository
{
    public class StaffStandardMenuRepository : ConnectToDb, IRepository<StaffStandardMenu>
    {
        public void Create(StaffStandardMenu staffStandardMenu)
        {
            throw new NotImplementedException();
        }

        public StaffStandardMenu Edit(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StaffStandardMenu> GetAll()
        {
            return db.Query<StaffStandardMenu>("Select * from StaffStandardMenu");
        }

        public void Update(StaffStandardMenu staffStandardMenu)
        {
            throw new NotImplementedException();
        }
    }
}