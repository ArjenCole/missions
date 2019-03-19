using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missions
{
    public static class mscAuthority
    {
        private static Dictionary<KeyValuePair<string, string>, string> au = new Dictionary<KeyValuePair<string, string>, string>();

        public static void Init()
        {
            //string tWHERE = "Authority='" + tAuthority + "'";
            DataTable tDT = mscDB.Search("*", "authority", null);
            foreach (DataRow feDR in tDT.Rows)
            {
                string auName = feDR[0].ToString();
                for (int i = 1; i <= tDT.Columns.Count - 1; i++)
                {
                    KeyValuePair<string, string> t = new KeyValuePair<string, string>(auName, tDT.Columns[i].ColumnName);
                    au.Add(t, feDR[i].ToString());
                }
            }
        }

        public static string Result(string pAuthority, string pOperation)
        {
            return au[new KeyValuePair<string, string>(pAuthority, pOperation)];
        }
    }
}
