using OrderManagement.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.DataInfrastructure.IdentityEntities
{
   public class ApplcationBranch:Branch
    {
        public ICollection<ApplicationUser> Users { get; set; }
    }
}
