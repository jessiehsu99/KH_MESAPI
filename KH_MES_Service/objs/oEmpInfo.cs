using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KH_MES_Service.objs
{
    public class oEmpInfoExample : oEmpInfo
    {
        public oEmpInfoExample()
        {
            UserID = "emp id";
            UserNo = "emp no";
            UserName = "emp name";
            Pwd = "Pass word";
        }
    }


    public class oEmpInfo 
    {
        public oEmpInfo()
        {
            MES_Result = new MesException();
        }
        public MesException MES_Result { get; set; }

        public string UserID { get; set; }
        public string UserNo { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
  
    }
}
