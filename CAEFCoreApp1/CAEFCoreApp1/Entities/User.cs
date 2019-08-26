using System;
using System.Collections.Generic;
using System.Text;

namespace CAEFCoreApp1.DataAccess.Entities
{
  public class User
    {
        public int UserID { get; set; }
        public string Firstname { get; set; }
        public string Password { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
