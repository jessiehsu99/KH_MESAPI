using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KH_MES_Service
{
    public static class CreateRule
    {
        public static KH_MES_Service.InterFace.EmpInterFace MESRule_Emp() 
        {
            KH_MES_Service.InterFace.EmpInterFace R = new KH_MES_Service.Rule.EmpRule();
            return R;
        }

        public static KH_MES_Service.InterFace.RPTInterFace MESRule_RPT()
        {
            KH_MES_Service.InterFace.RPTInterFace R = new KH_MES_Service.Rule.RPTRule();
            return R;
        }

        public static KH_MES_Service.InterFace.TGSInterFace MESRule_TGS()
        {
            KH_MES_Service.InterFace.TGSInterFace R = new KH_MES_Service.Rule.TGSRule();
            return R;
        }
    }
}
