using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

using KH_MES_Service.objs;

namespace Pages.Controllers
{
    public class EmpController : Controller
    {
        [HttpPost]
        // GET: Emp
        public ActionResult getEmpInfo(iEmpData inData)
        {
            oEmpInfo Result = new oEmpInfo();

            var svc = KH_MES_Service.CreateRule.MESRule_Emp();

            Result = svc.GetEmpInfo_byEmpData(inData);

            return new JsonNetResult(Result); ;
        }
    }
}