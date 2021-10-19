using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

namespace KH_MES_Service.objs
{
  public  class oViewData
    {
        public string TableName { get; set; }

        public JArray Datas { get; set; }

    }
}
