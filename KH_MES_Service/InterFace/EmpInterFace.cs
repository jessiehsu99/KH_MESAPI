using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KH_MES_Service.objs;

namespace KH_MES_Service.InterFace
{
    public interface EmpInterFace
    {

        /// <summary>
        /// 依使用者工號&密碼取得使用者資料
        /// </summary>
        /// <param name="inData"></param>
        /// <returns></returns>
        oEmpInfo GetEmpInfo_byEmpData(iEmpData inData);
        /// <summary>
        /// 依使用者工號取得使用者資料
        /// </summary>
        /// <param name="inData"></param>
        /// <returns></returns>
        oEmpInfo GetEmpInfo_byUserNo(string inData);
        /// <summary>
        /// 依使用者ID取得使用者資料
        /// </summary>
        /// <param name="inData"></param>
        /// <returns></returns>
        oEmpInfo GetEmpInfo_byUserID(string inData);

        /// <summary>
        /// 取出當前所有使用者資訊
        /// </summary>
        /// <returns></returns>
        List<oEmpInfo> GetEmpInfoList();

        /// <summary>
        /// 禁用/啟用人員
        /// </summary>
        /// <param name="inData"></param>
        /// <returns></returns>
        oEmpInfo TransEnabledUser_byUserNo(iEmpData inData);
    }
}
