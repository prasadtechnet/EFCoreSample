using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.DataInfrastructure.IdentityEntities
{
   public class ApplicationRole: IdentityRole<string>
    {
        public override string Id { get; set ; }
    }
}
