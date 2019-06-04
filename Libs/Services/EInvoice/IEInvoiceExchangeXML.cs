using System;
using System.Collections.Generic;
using System.Text;

namespace EInvLib.Services.EInvoice
{
    /// <summary>
    /// Mig B2B交換
    /// </summary>
    public interface IEInvoiceExchangeXML
    {
        /// <summary>
        /// 接收開立確認
        /// </summary>
        void MakeConfirm();
        /// <summary>
        /// 接收作廢確認
        /// </summary>
        void CancelConfirm();
        /// <summary>
        /// 接收退回確認
        /// </summary>
        void RejectConfirm();
        /// <summary>
        /// 接收開立折讓確認
        /// </summary>
        void MakeAllowanceConfirm();
        /// <summary>
        /// 接收作廢折讓確認
        /// </summary>
        void CancelAllowanceConfirm();
    }
}
