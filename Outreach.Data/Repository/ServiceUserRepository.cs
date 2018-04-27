using Dapper;
using Outreach.Common.Interfaces;
using Outreach.Entities.ServiceUsers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Outreach.Data.Repository
{
    public class ServiceUserRepository : ConnectToDb, IRepository<ServiceUser>
    {
        DynamicParameters param;
        public ServiceUserRepository()
        {
            param = new DynamicParameters();
        }
        public void Create(ServiceUser serviceUser)
        {
            PopulateParams(serviceUser);
            db.Open();
            db.Execute("sp_InsertServiceUser", param, commandType: CommandType.StoredProcedure);
            db.Close();
        }
        public ServiceUser Edit(int id)
        {
            ServiceUser serviceUser = GetAll().ToList().SingleOrDefault(m => m.Id == id);
            if (serviceUser == null)
                throw new Exception("Record not found!");
            return serviceUser;
        }

        public IEnumerable<ServiceUser> GetAll()
        {
            return db.Query<ServiceUser>("Select * from ServiceUser").ToList();
        }

        public void Update(ServiceUser serviceUser)
        {
            PopulateParams(serviceUser);
            param.Add("@BranchId", serviceUser.BranchId);
            db.Open();
            db.Execute("sp_UpdateBranch", param, commandType: CommandType.StoredProcedure);
            db.Close();
        }
        private void PopulateParams(ServiceUser serviceUser)
        {
            param.Add("@FName", serviceUser.FirstName);
            param.Add("@LName", serviceUser.LastName);
            param.Add("@Dob", serviceUser.BirthDate);
            param.Add("@DoctorId", serviceUser.DoctorId);
            param.Add("@StaffId", serviceUser.StaffId);
            param.Add("@BranchId", serviceUser.BranchId);



        }
    }
    }