using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using KH_MES_Service.objs;

namespace Pages.Controllers
{
    public class TGSController : Controller
    {
        // GET: TGS
        public ActionResult GetTerminalList()
        {
            List<oTerminalInfo> Result = new List<oTerminalInfo>();

            var svc = KH_MES_Service.CreateRule.MESRule_TGS();

            Result = svc.GetTerminalList();

            return new JsonNetResult(Result); ;
        }

        public ActionResult CA_CODE_COMMAND_SMT(iTGSInData InData)
        {

            var svc = KH_MES_Service.CreateRule.MESRule_TGS();

            var Result = svc.CA_CODE_COMMAND_SMT(InData);

            return new JsonNetResult(Result); ;
        }


    }
}