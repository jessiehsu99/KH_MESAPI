using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KH_MES_Service.InterFace;
using KH_MES_Service.objs;

namespace KH_MES_Service.InterFace
{
   public interface TGSInterFace
    {
        List<oTerminalInfo> GetTerminalList();


        string CA_CODE_COMMAND_SMT(iTGSInData data);
    }
}
