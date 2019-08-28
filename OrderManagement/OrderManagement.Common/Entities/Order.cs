using OrderManagement.Common.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Common.Entities
{
    public class Order: BaseEntity
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string UserId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? CGST { get; set; }
        public decimal? SGST { get; set; }
        public decimal? IGST { get; set; }
        public decimal? TotalAmount { get; set; }        
        public ICollection<OrderItem> OrderItems { get; set; }


    }
}
