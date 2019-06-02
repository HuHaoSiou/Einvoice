using System;
using System.Collections.Generic;
using System.Text;

namespace Libs.Services.EInvoice
{
    /// <summary>
    /// Mig存證
    /// </summary>
    public interface IEInvoiceXML
    {
        /// <summary>
        /// 開立
        /// </summary>
        void Make();
        /// <summary>
        /// 作廢
        /// </summary>
        void Cancel();
        /// <summary>
        /// 退回
        /// </summary>
        void Reject();
        /// <summary>
        /// 註銷
        /// </summary>
        void Void();
        /// <summary>
        /// 開立折讓
        /// </summary>
        void MakeAllowance();
        /// <summary>
        /// 作廢
        /// </summary>
        void CancelAllowance();
    }
}
