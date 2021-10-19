using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KH_MES_Service.objs;


namespace KH_MES_Service.InterFace
{
    public interface RPTInterFace
    {
        /// <summary>
        /// 依名稱取得視圖資訊
        /// </summary>
        /// <param name="ReportName"></param>
        /// <returns></returns>
        oRPT_ViewInfo GetRPTInfo(string ReportName);

        /// <summary>
        /// 取得所有視圖資訊
        /// </summary>
        /// <returns></returns>
        List<oRPT_ViewInfo> GetRPTInfos();


        List<Newtonsoft.Json.Linq.JObject> GetData();
    }
}
