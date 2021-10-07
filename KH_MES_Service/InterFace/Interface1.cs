using KH_MES_Service.objs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KH_MES_Service.InterFace
{
   public interface Interface1
    {
        /// <summary>
        /// 依使用者工號&密碼取得使用者資料
        /// </summary>
        /// <param name="inData"></param>
        /// <returns></returns>
        oEmpInfo GetEmpInfo_byEmpData(iEmpData inData);
    }
}
