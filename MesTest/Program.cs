using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KH_MES_Service;
using KH_MES_Service.objs;
using Newtonsoft.Json.Linq;

namespace MesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var API = new APIService.WebAPI();
            //API.SetUrl("http://10.8.1.115:9101/mes_webapi/liteonApi/Login/PostPlus");
            //var _TK = API.Request<TK>(new { Time = 3600, AppID = "AP1", UserName = "AP", UserPassword = "AP" });

            //API.SetUrl("http://10.8.1.115:9101/mes_webapi/liteonApi/Svc_Emp/getEmpInfo");
            //API.SetSwaggerToken(_TK.Token);
            //var R = API.Request(new { UserNo = "10027202", Pwd = "1", Enabled = true });

            //var a = 1;
            //return;
            //var _emp = CreateRule.MESRule_Emp(); ;
            //var R = _emp.TransEnabledUser_byUserNo(new iEmpData() { UserNo = "001", Enabled = true });

            var _SVC = CreateRule.MESRule_TGS();

            iTGSInData d = new iTGSInData() { 
                TSAJET1="1",
                TSAJET2= "10024483",
                TSAJET3= "N/A",
                TSAJET4= "N/A",
                TSAJET4TON = "N/A",
                TSAJET5 = "N/A",
                TSAJET5TON = "N/A",
                TLINEID= "11013",
                TSTAGEID= "12027",
                TPROCESSID= "110082",
                TTERMINALID= "10000051"
            };

            var aaa = _SVC.CA_CODE_COMMAND_SMT(d);

            var r = 1;

        }
    }

    class TK
    {
        public string Token { get; set; }
        public string Status { get; set; }
        public string Msg { get; set; }
    }
}

