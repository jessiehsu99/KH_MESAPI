using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KH_MES_Service;
using KH_MES_Service.objs;

namespace MesTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var _emp = CreateRule.MESRule_Emp();



            var R = _emp.TransEnabledUser_byUserNo(new iEmpData() { UserNo = "001", Enabled = true });



            var a = 1;

        }
    }
}
