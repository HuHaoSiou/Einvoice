using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EInvLib.DBContexts;
using EInvLib.Models.EInvCenter;

namespace EInvLib.Services.Flow
{
    abstract class IFlowServiceBase : IFlowService
    {
        protected EInvCenterContext _DBContext;
        protected FlowOrder _CurPaymentInfo;
        public FlowOrder CurPaymentInfo
        {
            get
            {
                return this._CurPaymentInfo;
            }
        }
        abstract public string Name { get; }
        public IFlowServiceBase(EInvCenterContext ECContext)
        {
            this._DBContext = ECContext;
        }

        abstract public string MakeHtmlForm(FlowOrder Order);
        abstract public void SetEnv(FlowEnv Env);
        abstract public FlowOrder GetParameter();
        public bool Pay(FlowOrder Order)
        {
            var PaymentInfo = this.GetParameter();
            this._CurPaymentInfo = this._DBContext.FlowOrders.Where(x => x.FlowOrderNo == PaymentInfo.FlowOrderNo).First();
            this._CurPaymentInfo.PayTimeStamp = DateTime.Now;
            this._CurPaymentInfo.PayType = PaymentInfo.PayType;
            this._CurPaymentInfo.PayAmount = PaymentInfo.PayAmount;
            bool res = (this._CurPaymentInfo.PayAmount == this._CurPaymentInfo.Amount) && this._CurPaymentInfo.PayType == null;
            return res;
        }
    }
}
