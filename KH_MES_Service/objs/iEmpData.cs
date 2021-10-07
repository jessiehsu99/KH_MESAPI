using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KH_MES_Service.objs
{
    
    public class iEmpDataExample : iEmpData
    {
        public iEmpDataExample()
        {
            UserNo = "10099999";
            UserNo = "aaaaabbbbccc";
            Pwd = "a93kn1-/f+1as";
            Enabled = true;

        }
    }


   public class iEmpData
    {
        public iEmpData()
        {
          
        }
        public string UserID { get; set; }
        public string UserNo { get; set; }
        public string Pwd { get; set; }
        public bool Enabled { get; set; }
    }
}
