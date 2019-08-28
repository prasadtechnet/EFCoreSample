using OrderManagement.Common.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Common.Entities
{
    public class Product: BaseEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
     
    }
}
