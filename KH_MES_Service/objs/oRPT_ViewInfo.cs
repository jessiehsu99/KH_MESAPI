using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KH_MES_Service.objs
{
    public class oRPT_ViewInfoExample : oRPT_ViewInfo
    {
        public oRPT_ViewInfoExample()
        {
            TableName = "Sample Table Name";
            Columns.Add(new oRPT_ViewColumn() { ColumnName = "Column01", DataType = "VARCHAR2" });
            Columns.Add(new oRPT_ViewColumn() { ColumnName = "Column02", DataType = "NUMBER" });
            Columns.Add(new oRPT_ViewColumn() { ColumnName = "Column03", DataType = "DATE" });
        }
    }


    public class oRPT_ViewInfo
    {
        public oRPT_ViewInfo()
        {
            Columns = new List<oRPT_ViewColumn>();
        }

        public string TableName { get; set; }
        public List<oRPT_ViewColumn> Columns { get; set; }

    }

    public class oRPT_ViewColumn
    {
        public string ColumnName { get; set; }
        public string DataType { get; set; }
    }

    public class RPT_ViewColumn
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
    }
}
