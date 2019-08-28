using OrderManagement.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.DataInfrastructure.IdentityEntities
{
   public class ApplicationUserBranch
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public string BranchId { get; set; }

        public  ApplicationUser User { get; set; }
        public  Branch Branch { get; set; }
    }
}
