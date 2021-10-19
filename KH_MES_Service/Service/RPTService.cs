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
    class RPTService
    {
        //設定DB連線(統一抓config內MES_DB連線字段)
        DBHelper db = new DBHelper("MES_DB");

        /// <summary>
        /// 依視圖名稱取得視圖資訊
        /// </summary>
        /// <param name="ReportName"></param>
        /// <returns></returns>
        public oRPT_ViewInfo GetRPTInfo(string ReportName)
        {
            //設定DB Cmd
            string SqlStr = @"select a.table_name,a.column_name,a.data_type
                              from user_tab_cols a
                              left join user_objects b on a.table_name=object_name and b.object_type='VIEW'
                              where 1=1
                              and :REPORTNAME
                              and a.table_name like 'RPT_%'
                              order by a.table_name,a.column_id";

            var cmd = db.CreateCommand(SqlStr, new Dictionary<string, object> { { "REPORTNAME", ReportName } });

            //執行Cmd
            var Col = db.ExecuteList<oRPT_ViewColumn>(cmd);

            if (Col == null) { new MesException(401, "找不到指定的視圖"); };

            oRPT_ViewInfo R = new oRPT_ViewInfo() { TableName = ReportName, Columns = Col };

            //回傳結果
            return R;

        }

        /// <summary>
        /// 取得所有視圖資料
        /// </summary>
        /// <returns></returns>
        public List<oRPT_ViewInfo> GetRPTInfos()
        {
            List<oRPT_ViewInfo> Result = new List<oRPT_ViewInfo>();

            //設定DB Cmd
            string SqlStr = @"select a.table_name TableName,a.column_name ColumnName,a.data_type DataType
                              from user_tab_cols a
                              left join user_objects b on a.table_name=object_name and b.object_type='VIEW'
                              where 1=1
                              and a.table_name like 'RPT_%'
                              order by a.table_name,a.column_id";

            //執行Cmd
            var Col = db.ExecuteList<RPT_ViewColumn>(SqlStr);

            var T = (from o in Col select o.TableName).Distinct();

            foreach(var table in T)
            {
                var c = (from s in Col where s.TableName == table select new { s.ColumnName, s.DataType });

                List<oRPT_ViewColumn> _Column = new List<oRPT_ViewColumn>();
                foreach(var ListCol in c)
                {
                    _Column.Add(new oRPT_ViewColumn() { ColumnName=ListCol.ColumnName,DataType=ListCol.DataType});
                }

                Result.Add(new oRPT_ViewInfo()
                {
                    TableName = table,
                    Columns = _Column
                }); 
            }


            //回傳結果
            return Result;

        }
        public List<JObject> GetData()
        {


            var J = db.ExecuteList<JObject>("select* from RPT_IQC_INSPRESULT where rownum<10");
            return J;
        }

    }
}
