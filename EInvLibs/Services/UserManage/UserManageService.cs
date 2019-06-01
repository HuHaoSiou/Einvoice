using EInvLib.DBContexts;
using EInvLib.Models.EInvCenter;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
namespace EInvLib.Services.UserManage
{
    /// <summary>
    /// 使用者管理模組
    /// </summary>
    //class UserManageService : IUserManageService<Member>
    //{
    //    protected Member _CurUser;
    //    protected EInvCenterContext _ECContext;
    //    public UserManageService(EInvCenterContext ECContext)
    //    {
    //        this._ECContext = ECContext;
    //    }

    //    public Member CurrentUser
    //    {
    //        get
    //        {
    //            return this._CurUser;
    //        }
    //    }

    //    public bool SignIn(Expression<Func<Member, bool>> expression)
    //    {
    //        try
    //        {
    //            this._CurUser = this._ECContext.Members.Where(expression).First();
    //            return true;
    //        }
    //        catch
    //        {
    //            return false;
    //        }
    //    }

    //    public void SignOut()
    //    {
    //        this._CurUser = null;
    //    }

    //    public bool SignUp(Member NewT)
    //    {
    //        this._ECContext.Members.Add(NewT);
    //        return this._ECContext.SaveChanges() > 0;
    //    }

    //    public bool Update(Member NewT)
    //    {
    //        this._ECContext.Entry(this.CurrentUser).CurrentValues.SetValues(NewT);
    //        return this._ECContext.SaveChanges() > 0;
    //    }
    //}
}
