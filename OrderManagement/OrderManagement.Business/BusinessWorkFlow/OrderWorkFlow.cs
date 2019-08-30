using OrderManagement.Business.BusinessWorkFlow.Core;
using OrderManagement.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Business.BusinessWorkFlow
{
    
   public class OrderWorkFlow: IWorkFlowManager
    {
        //histroy,Features activities based on status
        IWorkflowHandler _hdlerStatus;
        private Dictionary<string, IWorkflowHandler> objDict;
        public OrderWorkFlow(Order objOrder)
        {
          
            objDict = new Dictionary<string, IWorkflowHandler>
            {
                {"OPEN",new OpenHandler(objOrder)},
                {"APPROVED",new ApproveHandler(objOrder)},
                {"REJECTED",new RejectHandler(objOrder)},
                {"CLOSED",new CloseHandler(objOrder)}
            };
            _hdlerStatus = objDict[objOrder.Status.ToUpper()];
        }

        public void Execute()
        {
            _hdlerStatus.Handle();
        }

        public class OpenHandler : IWorkflowHandler, IDisposable
        {
            private Order _order;
            public OpenHandler(Order objOrder)
            {
                _order = objOrder;
            }

          

            public  void Handle()
            {
                

                throw new NotImplementedException();
            }
            public void Dispose()
            {
                this.Dispose();
            }
        }
        public class ApproveHandler : IWorkflowHandler, IDisposable
        {
            private Order _order;
            public ApproveHandler(Order objOrder)
            {
                _order = objOrder;
            }
            public  void Handle()
            {
                throw new NotImplementedException();
            }
            public void Dispose()
            {
                this.Dispose();
            }
        }
        public class RejectHandler : IWorkflowHandler, IDisposable
        {
            private Order _order;
            public RejectHandler(Order objOrder)
            {
                _order = objOrder;
            }
            public  void Handle()
            {
                throw new NotImplementedException();
            }
            public void Dispose()
            {
                this.Dispose();
            }
        }
        public class CloseHandler : IWorkflowHandler, IDisposable
        {
            private Order _order;
            public CloseHandler(Order objOrder)
            {
                _order = objOrder;
            }
            public  void Handle()
            {
                throw new NotImplementedException();
            }
            public void Dispose()
            {
                this.Dispose();
            }
        }
    }
}
