using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KH_MES_Service.InterFace;
using KH_MES_Service.objs;

namespace KH_MES_Service.Rule
{
    /// <summary>
    /// 依工號及密碼取得使用者資訊
    /// </summary>
    class EmpRule : Exception, EmpInterFace
    {
        /// <summary>
        /// 依使用者工號&密碼取得使用者資料
        /// </summary>
        /// <param name="inData"></param>
        /// <returns></returns>
        public oEmpInfo GetEmpInfo_byEmpData(iEmpData inData)
        {
            try
            {
                //初始化emp服務
                Service.EmpService svc = new Service.EmpService();

                //取得emp資料
                var Result = svc.GetInfobyNo(inData.UserNo);

                //檢查是否有此工號
                if (Result == null)
                {
                    throw new MesException(401, string.Format("找不到工號:{0}的人員資料!", inData.UserNo));
                }

                //檢查密碼是否正確
                if (Result.Pwd != inData.Pwd)
                {
                    throw new MesException(401, string.Format("密碼錯誤!"));
                }

                //回傳結果
                return Result;
            }
            catch (MesException ex)
            {
                return ex.To<oEmpInfo>();//回傳例外並轉型
            }
        }

        /// <summary>
        /// 依使用者工號取得使用者資料
        /// </summary>
        /// <param name="inData"></param>
        /// <returns></returns>
        public oEmpInfo GetEmpInfo_byUserNo(string inData)
        {
            try
            {
                //初始化emp服務
                Service.EmpService svc = new Service.EmpService();

                //取得emp資料
                var Result = svc.GetInfobyNo(inData);

                //回傳結果
                return Result;
            }
            catch (MesException ex)
            {
                return ex.To<oEmpInfo>();//回傳例外並轉型
            }
        }


        /// <summary>
        /// 依使用者ID取得使用者資料
        /// </summary>
        /// <param name="inData"></param>
        /// <returns></returns>
        public oEmpInfo GetEmpInfo_byUserID(string inData)
        {
            try
            {
                //初始化emp服務
                Service.EmpService svc = new Service.EmpService();

                //取得emp資料
                var Result = svc.GetInfobyID(inData);

                //回傳結果
                return Result;

            }
            catch (MesException ex)
            {
                return ex.To<oEmpInfo>();//回傳例外並轉型
            }
        }

        /// <summary>
        /// 取出當前所有使用者資訊
        /// </summary>
        /// <returns></returns>
        public List<oEmpInfo> GetEmpInfoList()
        {
            try
            {
                //初始化emp服務
                Service.EmpService svc = new Service.EmpService();

                //取得emp資料
                var Result = svc.GetInfoList();

                //回傳結果
                return Result;

            }
            catch (MesException ex)
            {
                return ex.To<List<oEmpInfo>>();//回傳例外並轉型
            }
        }

        /// <summary>
        /// 禁用/啟用人員
        /// </summary>
        /// <param name="inData"></param>
        /// <returns></returns>
        public oEmpInfo TransEnabledUser_byUserNo(iEmpData inData)
        {
            try
            {
                //初始化emp服務
                Service.EmpService svc = new Service.EmpService();

                //取得emp資料
                var Result = svc.GetInfobyNo(inData.UserNo);

                //檢查是否有此工號
                if (Result == null)
                {
                    throw new MesException(401, string.Format("找不到工號:{0}的人員資料!", inData.UserNo));
                }

                //禁用/啟用人員
                svc.EnabledUser(inData.UserNo, inData.Enabled);

                //回傳結果
                return Result;

            }
            catch (MesException ex)
            {
                return ex.To<oEmpInfo>();//回傳例外並轉型
            }
        }
    }
}
