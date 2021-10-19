using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KH_MES_Service.InterFace;
using KH_MES_Service.objs;

namespace KH_MES_Service.Rule
{
    class TGSRule : Exception, TGSInterFace
    {
        public List<oTerminalInfo> GetTerminalList()
        {
            Service.TerminalService svc = new Service.TerminalService();

            return svc.GetTerminalList();
        }

        public string CA_CODE_COMMAND_SMT(iTGSInData data)
        {
            Service.TGSService svc = new Service.TGSService();

            return svc.CA_CODE_COMMAND_SMT(data);
        }
        
    }
}
