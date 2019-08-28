using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Common.Entities
{
   public class ObjectIndex
    {
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public string IdPrefix { get; set; }
        public int IndexNo { get; set; }
        public int StringLength { get; set; }
    }
}
