using Dapper;
using Outreach.Common.Interfaces;
using Outreach.Entities.Models.ServiceUsers.Menu;
using Outreach.Entities.Models.Staffs.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Data.Repository
{
    public class PopulatedStaffStandardMenuRepository:ConnectToDb, IRepository<PopulatedStaffStandardMenu>
    {
        public void Create(PopulatedStaffStandardMenu populatedStaffStandardMenu)
    {
        throw new NotImplementedException();
    }

    public PopulatedStaffStandardMenu Edit(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<PopulatedStaffStandardMenu> GetAll()
    {
        return db.Query<PopulatedStaffStandardMenu>("Select * from PopulatedStaffStandardMenu");
    }

    public void Update(PopulatedStaffStandardMenu populatedStaffStandardMenu)
    {
        throw new NotImplementedException();
    }
}
    
}