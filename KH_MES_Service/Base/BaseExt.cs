using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KH_MES_Service.objs;

namespace KH_MES_Service.Base
{
  public  static class BaseExt
    {
        public static void CreateParam(this DbCommand cmd ,DBParam param, ParameterDirection Direction = ParameterDirection.Input)
        {
            var _param = cmd.CreateParameter();
            _param.ParameterName = param.ParamName;
            _param.Value = param.ParamValue;
            _param.Direction = Direction;
            cmd.Parameters.Add(_param);
        }
    }
}
