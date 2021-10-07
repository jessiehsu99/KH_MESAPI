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

        public static KH_MES_Service.InterFace.Interface1 MESRule_Test()
        {
            KH_MES_Service.InterFace.Interface1 R = new KH_MES_Service.Rule.EmpRule();

            return R;
        }
    }
}
