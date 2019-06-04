using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EInvLib.Services.EInvoice;
using EinvLib.Models.Inv;

namespace EInvCenter.Controllers
{
    public class EInvoiceAPIController :Controller ,IEInvoiceXML
    {
        protected IEInvoiceXML _EInvService;
        public EInvoiceAPIController(IEInvoiceXML EInvService)
        {

        }

        public void Cancel(string InvNo, string RndNo, string Reason)
        {
            throw new NotImplementedException();
        }

        public void CancelAllowance(string AllowNo, string Reason)
        {
            throw new NotImplementedException();
        }

        public void Make(Invoice Inv)
        {
            throw new NotImplementedException();
        }

        public void MakeAllowance(ICollection<Invoice> invoices)
        {
            throw new NotImplementedException();
        }

        public void Reject(string InvNo, string RndNo, string Reason)
        {
            throw new NotImplementedException();
        }

        public void Void(string InvNo, string RndNo, string Reason)
        {
            throw new NotImplementedException();
        }
    }
}