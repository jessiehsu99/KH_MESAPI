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
    class TerminalService
    {
        //設定DB連線(統一抓config內MES_DB連線字段)
        DBHelper db = new DBHelper("MES_DB");

        public List<oTerminalInfo> GetTerminalList()
        {
            string SqlStr = string.Format(@"select a.terminal_id,a.terminal_name,b.pdline_id,b.pdline_name,c.process_id,c.process_name,d.stage_id,d.stage_name
                                            from sys_terminal a
                                            left join sys_pdline b on a.pdline_id=b.pdline_id
                                            left join sys_process c on a.process_id=c.process_id
                                            left join sys_stage d on a.stage_id = d.stage_id
                                            order by b.pdline_name,d.stage_name,c.process_name,a.terminal_name");

            //執行Cmd
            var R = db.ExecuteList<oTerminalInfo>(SqlStr);
            //回傳結果
            return R;
        }
    }
}
