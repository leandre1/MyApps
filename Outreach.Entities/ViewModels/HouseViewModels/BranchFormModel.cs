using Outreach.Entities.Branches;
using Outreach.Entities.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Outreach.Entities.HouseViewModels
{
    public class BranchFormModel
    {
        
        public Branch Branch { get; set; }
        public List<House> Houses { get; set; }

    }
}