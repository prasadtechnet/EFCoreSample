using OrderManagement.Common.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Common.Entities
{
    public class Customer:BaseEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }  
        public string BranchName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }

        public string BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
