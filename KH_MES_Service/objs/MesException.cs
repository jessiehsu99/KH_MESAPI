using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KH_MES_Service.objs
{
    public class MesException : Exception, ISerializable
    {
        public MesException() : base("OK")
        {
            HResult = 200;
        }
        public MesException(int code, string message) : base(message)
        {
            HResult = code;
        }
    }

    public static class MesExceptionExt
    {
        public static T To<T>(this MesException ex) where T : new()
        {
            var R = new T();
            R.GetType().GetProperty("MES_Result").SetValue(R,ex);
            return R;
        }
    }
}
