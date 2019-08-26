using System;
using System.Collections.Generic;
using System.Text;

namespace CAEFCoreApp1.DataAccess.Entities
{
   public class Role
    {
        public int RoleID { get; set; }
        public string Name { get; set; }      
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
