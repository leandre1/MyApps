using Dapper;
using Outreach.Entities.Branches;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using Outreach.Common.Interfaces;

namespace Outreach.Data.Repository
{
    public class BranchRepository : ConnectToDb,IRepository<Branch>
    {
        DynamicParameters param;
        public BranchRepository()
        {
            param = new DynamicParameters();
        }
        public void Create(Branch branch)
        {
            PopulateParams(branch);
            db.Open();
            db.Execute("sp_InsertBranch",param,commandType:CommandType.StoredProcedure);
            db.Close();
        }

       

        public Branch Edit(int id)
        {
            Branch branch = GetAll().ToList().SingleOrDefault(m => m.BranchId == id);
            if (branch == null)
                throw new Exception("Record not found!");
              return branch;
        }

    

        public IEnumerable<Branch> GetAll()
        {
            return db.Query<Branch>("Select * from Branch").ToList();
        }

  
        public void Update(Branch branch)
        {
                PopulateParams(branch);
                param.Add("@BranchId", branch.BranchId);
                db.Open();
                db.Execute("sp_UpdateBranch", param, commandType: CommandType.StoredProcedure);
                db.Close();     
        }

     
        private void PopulateParams(Branch branch)
        {
            param.Add("@Name", branch.Name);
            param.Add("@HouseId", branch.HouseId);
            param.Add("@Phone", branch.Phone);
        }
    }
}