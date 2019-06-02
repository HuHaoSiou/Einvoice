using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EInvLib.DBContexts;
using Microsoft.AspNetCore.Mvc;

namespace EInvCenter.Controllers
{
    public class EInvoiceController : Controller
    {
        protected Mig32Context _B2CContext;
        public EInvoiceController(Mig32Context newContext)
        {
            this._B2CContext = newContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Query(string InvNo, string RndNo)
        {
            var EInv = this._B2CContext.C0401_Invoices.Where(x => x.Main.InvoiceNumber == InvNo && x.Main.RandomNumber == RndNo);
            return View(EInv);
        }
    }
}