using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace missions
{
    public class mcDepartment
    {
        public string Name;
        public string Abbreviation;
        public string Parent;
        public string Remark;
        public int Key;

        public string DirParent { get { return dirParent(); } }
        private string dirParent()
        {
            if (Parent == string.Empty) return Parent;
            if (!Parent.Contains(",")) return Parent;
            var parents = Parent.Split(',');
            return parents.Last();
        }
        public mcDepartment()
        {
            Name = "新建部门";
            Abbreviation = "新部门";
            Parent = null;
            Remark = string.Empty;
        }
        public mcDepartment(DataRow pDR)
        {
            Name = pDR["Name"].ToString();
            Abbreviation = pDR["Abbreviation"].ToString();
            Parent = pDR["Parent"].ToString();
            Remark = pDR["Remark"].ToString();
            Key = Convert.ToInt32(pDR["Key"]);
        }
    }
}
