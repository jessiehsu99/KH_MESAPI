using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using KH_MES_Service.objs;
using LITEON.MES.DB;
using Oracle.ManagedDataAccess.Client;
using KH_MES_Service.Base;
using Newtonsoft.Json.Linq;


namespace KH_MES_Service.Service
{
    class TGSService
    {
        //設定DB連線(統一抓config內MES_DB連線字段)
        DBHelper db = new DBHelper("MES_DB");

        public string CA_CODE_COMMAND_SMT(iTGSInData data)
        {
            //執行Cmd
            var R = db.ExecuteProcedure("CA_CODE_COMMAND_SMT",
                db.CreateParameter("TSAJET1",data.TSAJET1),
                db.CreateParameter("TSAJET2", data.TSAJET2),
                db.CreateParameter("TSAJET3", data.TSAJET3),
                db.CreateParameter("TSAJET4", data.TSAJET4),
                db.CreateParameter("TSAJET4TON", data.TSAJET4TON),
                db.CreateParameter("TSAJET5", data.TSAJET5),
                db.CreateParameter("TSAJET5TON", data.TSAJET5TON),
                db.CreateParameter("TLINEID", data.TLINEID),
                db.CreateParameter("TSTAGEID", data.TSTAGEID),
                db.CreateParameter("TPROCESSID", data.TPROCESSID),
                db.CreateParameter("TTERMINALID", data.TTERMINALID),
                db.CreateParameter("TNOW", DateTime.Now),
                db.CreateParameter("TREV", "KH_MES_Service"),
                db.OutputParameter("TRES"),
                db.OutputParameter("TNEXTPROC")
                );
            
            //回傳結果
            return R["TRES"].ToString();
        }
    }
}
