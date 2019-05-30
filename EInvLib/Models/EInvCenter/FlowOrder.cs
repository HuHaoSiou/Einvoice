using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EInvLib.Models.EInvCenter
{
    class FlowOrder
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// 建單時間
        /// </summary>
        public System.DateTime TimeStamp { get; set; }
        /// <summary>
        /// 應付金額
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// 付款時間
        /// </summary>
        public Nullable<System.DateTime> PayTimeStamp { get; set; }
        /// <summary>
        /// 付款金額
        /// </summary>
        public Nullable<int> PayAmount { get; set; }
        /// <summary>
        /// 付款方式
        /// </summary>
        public string PayType { get; set; }
        /// <summary>
        /// 金流單號
        /// </summary>
        public string FlowOrderNo { get; set; }
        /// <summary>
        /// 我方出貨單號
        /// </summary>
        public string OrderNo { get; set; }
        /// <summary>
        /// 捐贈Flag
        /// </summary>
        public int IsDonate { get; set; }
        /// <summary>
        /// 客戶編號
        /// </summary>
        public int CustomerID { get; set; }
        /// <summary>
        /// 發票ID
        /// </summary>
        public Nullable<Guid> InvId;
        /// <summary>
        /// 發票號碼
        /// </summary>
        public string InvNo;
    }
}
