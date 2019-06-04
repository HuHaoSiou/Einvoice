using EinvLib.Models.Inv;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvLib.Services.EInvoice
{
    /// <summary>
    /// Mig存證
    /// </summary>
    public interface IEInvoiceXML
    {
        /// <summary>
        /// 開立
        /// </summary>
        void Make(Invoice Inv);
        /// <summary>
        /// 作廢
        /// </summary>
        void Cancel(string InvNo,string RndNo,string Reason);
        /// <summary>
        /// 退回
        /// </summary>
        void Reject(string InvNo, string RndNo, string Reason);
        /// <summary>
        /// 註銷
        /// </summary>
        void Void(string InvNo, string RndNo, string Reason);
        /// <summary>
        /// 開立折讓
        /// </summary>
        void MakeAllowance(ICollection<Invoice> invoices);
        /// <summary>
        /// 作廢
        /// </summary>
        void CancelAllowance(string AllowNo,string Reason);
    }
}
