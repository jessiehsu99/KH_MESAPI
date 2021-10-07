using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KH_MES_Service.objs;
using LITEON.MES.DB;
using Oracle.ManagedDataAccess.Client;
using KH_MES_Service.Base;

namespace KH_MES_Service.Service
{
    class EmpService
    {
        //設定DB連線(統一抓config內MES_DB連線字段)
        DBHelper db = new DBHelper("MES_DB");

        /// <summary>
        /// 依ID取得使用者資訊
        /// </summary>
        /// <param name="UID"></param>
        /// <returns></returns>
        public oEmpInfo GetInfobyID(string UID)
        {
            //設定DB Cmd
            string SqlStr = string.Format(@"select emp_id UserID,emp_no UserNo,emp_name UserName,PASSWORD.decrypt(passwd) Pwd from sys_emp where emp_id=:UID");
            var cmd = db.CreateCommand(SqlStr, new Dictionary<string, object> { { "UID", UID } });

            //執行Cmd
            var R = db.ExecuteObject<oEmpInfo>(cmd);

            //回傳結果
            return R;
        }

        /// <summary>
        /// 依工號取得使用者資訊
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public oEmpInfo GetInfobyNo(string No)
        {
            //設定DB Cmd
            string SqlStr = string.Format(@"select emp_id UserID,emp_no UserNo,emp_name UserName,PASSWORD.decrypt(passwd) Pwd from sys_emp where emp_no=:NO");
            var cmd = db.CreateCommand(SqlStr, new Dictionary<string, object> { { "NO", No } });

            //執行Cmd
            var R = db.ExecuteObject<oEmpInfo>(cmd);

            //回傳結果
            return R;
        }



        /// <summary>
        /// 取得當下所有使用者資訊
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public List<oEmpInfo> GetInfoList()
        {
            //設定DB Cmd
            string SqlStr = string.Format(@"select emp_id UserID,emp_no UserNo,emp_name UserName,PASSWORD.decrypt(passwd) Pwd from sys_emp");
            var cmd = db.CreateCommand(SqlStr);

            //執行Cmd
            var R = db.ExecuteList<oEmpInfo>(cmd);

            //回傳結果
            return R;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool EnabledUser(string UserNo, bool IsEnable)
        {
            //設定DB Cmd
            string SqlStr = string.Format(@"update sys_emp set ENABLED=:STATUS where emp_no=:NO");
            var cmd = db.CreateCommand(SqlStr);

            //載入查詢參數
            if (IsEnable)
            {
                cmd.CreateParam(new DBParam() { ParamName = "STATUS", ParamValue ="Y" });
            }
            else
            {
                cmd.CreateParam(new DBParam() { ParamName = "STATUS", ParamValue = "N" });
            }
            cmd.CreateParam(new DBParam() { ParamName = "NO", ParamValue = UserNo });

            //執行Cmd
            var R = db.ExecuteNonQuery(cmd);

            //回傳結果
            return true;
        }
    }
}
