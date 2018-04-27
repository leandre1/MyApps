using Autofac;
using Outreach.Common.Interfaces;
using Outreach.Data.Repository;
using Outreach.Entities.Branches;
using Outreach.Entities.Doctors;
using Outreach.Entities.Houses;
using Outreach.Entities.Models.ServiceUsers.Appointment;
using Outreach.Entities.Models.ServiceUsers.Menu;
using Outreach.Entities.Models.Staffs.Menu;
using Outreach.Entities.ServiceUsers;
using Outreach.Entities.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Web.IoC
{
    public class DataModule : Module
    {
        private string con;
        public DataModule(string conString)
            {
            this.con = conString;
            }
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<BranchRepository>().As<IRepository<Branch>>().InstancePerRequest();
            builder.RegisterType<HouseRepository>().As<IRepository<House>>().InstancePerRequest();
            builder.RegisterType<MedicalAppointmentRepository>().As<IRepository<MedicalAppointment>>();
            builder.RegisterType<MenuRepository>().As<IRepository<Menu>>().InstancePerRequest();
            builder.RegisterType<PopulatedStaffStandardMenuRepository>().As<IRepository<PopulatedStaffStandardMenu>>();
            builder.RegisterType<ServiceUserMenuRepository>().As<IRepository<ServiceUserMenu>>().InstancePerRequest();
            builder.RegisterType<ServiceUserRepository>().As<IRepository<ServiceUser>>().InstancePerRequest();
            builder.RegisterType<StaffStandardMenuRepository>().As<IRepository<StaffStandardMenu>>().InstancePerRequest();
            builder.RegisterType<StaffRepository>().As<IRepository<Staff>>().InstancePerRequest();
            builder.RegisterType<DoctorRepository>().As<IRepository<Doctor>>().InstancePerRequest();

            base.Load(builder);
        }
        
    }
}