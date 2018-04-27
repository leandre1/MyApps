using Dapper;
using Outreach.Common.Interfaces;
using Outreach.Entities.Models.ServiceUsers.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Data.Repository
{
    public class ServiceUserMenuRepository : ConnectToDb, IRepository<ServiceUserMenu>
    {
        public void Create(ServiceUserMenu serviceUserMenu)
        {
            throw new NotImplementedException();
        }

        public ServiceUserMenu Edit(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ServiceUserMenu> GetAll()
        {
          return  db.Query<ServiceUserMenu>("Select * from ServiceUserMenu");
        }

        public void Update(ServiceUserMenu serviceUserMenu)
        {
            throw new NotImplementedException();
        }
    }
}