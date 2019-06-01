using EInvLib.Models.EInvCenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
namespace EInvLib.Services.UserManage
{
    public interface IUserManageService<T>
    {
        T CurrentUser { get; }
        /// <summary>
        /// 使用者註冊
        /// </summary>
        /// <returns></returns>
        bool SignUp(T NewT);
        /// <summary>
        /// 登入
        /// </summary>
        /// <returns></returns>
        bool SignIn(Expression<Func<T,bool>> expression);
        /// <summary>
        /// 登出
        /// </summary>
        void SignOut();
        /// <summary>
        /// 更新資訊
        /// </summary>
        /// <returns></returns>
        bool Update(T NewT);
    }
}
