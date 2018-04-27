using Outreach.Entities.Branches;
using Outreach.Entities.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outreach.Entities.HouseViewModels
{
    public class HouseDisplayModel
    {
        public House House { get; set; }
        public Branch Branch { get; set; }
    }
}