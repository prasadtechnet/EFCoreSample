using System;
using System.Collections.Generic;
using System.Text;

namespace CAEFCoreApp1.DataAccess.Entities
{
   public class UserClaim
    {
        public int UserClaimID { get; set; }

        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
