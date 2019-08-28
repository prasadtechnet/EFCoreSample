using Microsoft.AspNetCore.Identity;
using OrderManagement.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.DataInfrastructure.IdentityEntities
{
   public class ApplicationUser:IdentityUser<string>
    {
        public override string Id { get ; set; }
        public override bool LockoutEnabled { get; set; } = false;

    }
}
