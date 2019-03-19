using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace missions
{
    public partial class FmDepartment : Form
    {
        private Dictionary<string, TreeNode> TNDic = new Dictionary<string, TreeNode>();
        public string Result = "";
        private DataTable depDT;

        public FmDepartment(DataTable pDT)
        {
            InitializeComponent();
            depDT = pDT.Copy();
            GetDepartments(depDT);
            //mscCtrl.searchDepartment("FmDepartment");
        }
        public void GetDepartments(DataTable pDT)
        {
            TreeNode rootTN=new TreeNode();
            foreach(DataRow feDR in pDT.Rows)
            {
                mcDepartment tmD = new mcDepartment(feDR);
                TreeNode tTN = new TreeNode(tmD.Name);
                string dParent = tmD.DirParent;
                string sKey = tmD.Key.ToString();
                TNDic.Add(sKey, tTN);
                tTN.Tag = sKey;
                if (tmD.DirParent == string.Empty) 
                    rootTN = tTN;
                else
                    TNDic[dParent].Nodes.Add(tTN);
            }
            tvDep.Nodes.Add(rootTN);
            tvDep.ExpandAll();
        }

        private void tvDep_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Result= e.Node.Tag.ToString();
            this.Close();
        }
    }
}
