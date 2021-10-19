using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KH_MES_Service.InterFace;
using KH_MES_Service.objs;

namespace KH_MES_Service.Rule
{
    class RPTRule : Exception, RPTInterFace
    {
        /// <summary>
        /// 依視圖名稱取得視圖資訊
        /// </summary>
        /// <param name="ReportName"></param>
        /// <returns></returns>
       public oRPT_ViewInfo GetRPTInfo(string ReportName)
        {
            Service.RPTService svc = new Service.RPTService();

            return svc.GetRPTInfo(ReportName);
        }

        /// <summary>
        /// 取得所有視圖資訊
        /// </summary>
        /// <returns></returns>
        public List<oRPT_ViewInfo> GetRPTInfos()
        {
            Service.RPTService svc = new Service.RPTService();

            return svc.GetRPTInfos();
        }

        public List<Newtonsoft.Json.Linq.JObject> GetData()
        {
            Service.RPTService svc = new Service.RPTService();
            return svc.GetData();
        }

    }
}
