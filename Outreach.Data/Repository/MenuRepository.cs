using Dapper;
using Outreach.Common.Interfaces;
using Outreach.Entities.Models.ServiceUsers.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Data.Repository
{
    public class MenuRepository : ConnectToDb,IRepository<Menu>
    {
        public void Create(Menu Menu)
        {
            throw new NotImplementedException();
        }

        public Menu Edit(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Menu> GetAll()
        {
            return db.Query<Menu>("Select * from Menu").ToList();
        }

        public void Update(Menu menu)
        {
            throw new NotImplementedException();
        }
    }
}