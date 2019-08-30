using OrderManagement.Business.BusinessWorkFlow;
using OrderManagement.Business.BusinessWorkFlow.Core;
using OrderManagement.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Business.Managers.OrderManager
{
    public class OrderManager
    {
      
        public OrderManager()
        {
            
        }

        public void Create(Order objOrder)
        {
          //  objOrder.Status = "Open";
           var _wfManager = new OrderWorkFlow(objOrder);
            _wfManager.Execute();
        }

    }
}
