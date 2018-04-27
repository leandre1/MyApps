using Outreach.Entities.Houses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Dapper;
using Outreach.Common.Interfaces;

namespace Outreach.Data.Repository
{
    public class HouseRepository : ConnectToDb,IRepository<House>
    {
        public void Create(House house)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public House Edit(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<House> GetAll()
        {
            return db.Query<House>("Select * from House").ToList();
        }

        public void Update(House house)
        {
            throw new NotImplementedException();
        }

        
    }
}