using OrderManagement.Common.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Common.Entities
{
    public class OrderItem: BaseEntity
    {

        public int Id { get; set; }
        public string ProductName { get; set; }  
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? Amount { get; set; }
        public string OrderId { get; set; }
        public Order Order { get; set; }
    }
}
