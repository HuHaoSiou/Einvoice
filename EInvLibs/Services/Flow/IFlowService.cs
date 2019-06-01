using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Specialized;
using EInvLib.Models.EInvCenter;

namespace EInvLib.Services.Flow
{
    /// <summary>
    /// 金流環境設定
    /// </summary>
    public enum FlowEnv
    {
        測試環境 = 0,
        正式環境 = 1
    }
    /// <summary>
    /// 金流模組
    /// 主要串接Web形式的第三方支付廠商
    /// </summary>
    public interface IFlowService
    {
        /// <summary>
        /// 前項付款資訊
        /// </summary>
        FlowOrder CurPaymentInfo { get; }
        /// <summary>
        /// 金流名稱
        /// </summary>
        string Name { get; }
        /// <summary>
        /// 產生HtmlForm
        /// </summary>
        /// <param name="Order"></param>
        /// <returns></returns>
        string MakeHtmlForm(FlowOrder Order);
        /// <summary>
        /// 設定金流環境參數
        /// </summary>
        /// <param name="Env"></param>
        void SetEnv(FlowEnv Env);
        /// <summary>
        /// 付款
        /// </summary>
        /// <param name="Order"></param>
        /// <returns></returns>
        bool Pay(FlowOrder Order);
    }
}
