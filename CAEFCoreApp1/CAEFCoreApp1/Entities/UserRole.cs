using System;
using System.Collections.Generic;
using System.Text;

namespace CAEFCoreApp1.DataAccess.Entities
{
   public class UserRole
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }

        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
