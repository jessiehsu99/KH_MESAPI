using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Swashbuckle.Examples;
using KH_MES_Service.objs;

namespace API_Template.Controllers
{
    public class Svc_EmpController : ApiController
    {

        /// <summary>
        /// 依使用者工號及密碼取得使用者資料
        /// </summary>
        /// <param name="inData"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerRequestExample(typeof(iEmpData), typeof(iaController))]
        [SwaggerResponseExample(HttpStatusCode.OK, typeof(oaController))]
        public oEmpInfo getEmpInfo(iEmpData inData)
        {
            oEmpInfo Result = new oEmpInfo();

            string Msg = string.Empty;

            var aaa = KH_MES_Service.CreateRule.MESRule_Emp();
            
            return aaa.GetEmpInfo_byEmpData(inData);


        }


        #region Example Model
        public class iaController : IExamplesProvider
        {
            public object GetExamples()
            {
                return new iEmpDataExample();
            }
        }
        public class oaController : IExamplesProvider
        {
            public object GetExamples()
            {
                return new oEmpInfoExample();
            }
        }

        #endregion

    }
}
