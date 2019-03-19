using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;

using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace missions
{
    //程序添加引用
    //Microsoft.Office.Interop.Excel.dll
    //程序集
    //Microsoft.CSharp

    static class mscExcel
    {
        #region 读取
        static private DataSet myds = new DataSet();//创建数据集

        static public DataSet getDS(string para_fileName, string para_sheetName)
        {
            string fileadd = Application.StartupPath + @"\" + para_fileName;//获得运行文件的存储路径

            OleDbConnection olecnt = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                + fileadd + ";Extended Properties=Excel 8.0");//连接EXCEL数据库
            olecnt.Open();//打开数据库连接
            OleDbDataAdapter oledbda = new OleDbDataAdapter("select * from [" + para_sheetName + "$]", olecnt);
            myds.Clear();
            oledbda.Fill(myds);
            oledbda.Dispose();
            olecnt.Close();
            return myds;
        }
        static public DataTable getDT(string para_fileName, string para_sheetName)
        {

            DataTable mydt = new DataTable();//创建数据表
            string fileadd = Application.StartupPath + @"\" + para_fileName;//获得运行文件的存储路径

            OleDbConnection olecnt = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                + fileadd + ";Extended Properties=Excel 12.0");//连接EXCEL数据库
            olecnt.Open();//打开数据库连接
            OleDbDataAdapter oledbda = new OleDbDataAdapter("select * from [" + para_sheetName + "$]", olecnt);
            mydt.Clear();
            oledbda.Fill(mydt);
            mydt.TableName = para_sheetName;
            oledbda.Dispose();
            olecnt.Close();
            return mydt.Copy();
        }
        #endregion

        #region 写入
        /// <summary>
        /// 导出到Excel
        /// </summary>
        /// <param name="pSaveFileName">默认文件名</param>
        /// <param name="pDGVQ">数据源，一个页面上的DataGridView控件</param>
        static public bool ExportExcel(string pSaveFileName, DataGridView pDGVQ, bool pMessageBox = true, string pWookSheetName = "Sheet")
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                //设置禁止弹出保存和覆盖的询问提示框  
                xlApp.DisplayAlerts = false;
                xlApp.AlertBeforeOverwriting = false;
            }
            catch (Exception)
            {
                MessageBox.Show("无法创建Excel对象,请确认已安装Excel。", "对象创建错误", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
            }

            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;

            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

            workbook.Worksheets.Add();


            Microsoft.Office.Interop.Excel.Worksheet worksheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
            worksheet1.Name = pWookSheetName;
            writeData(worksheet1, pDGVQ);

            bool fileSaved = false;
            if (pSaveFileName != "")
            {
                try
                {
                    workbook.SaveAs(pSaveFileName, 56);
                    workbook.Saved = true;
                    fileSaved = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " 文件可能正在使用。", "导出错误", MessageBoxButtons.OK);
                    return false;
                }

            }
            xlApp.Quit();
            GC.Collect();//强行销毁 
            if (fileSaved && pMessageBox)
                MessageBox.Show(pSaveFileName + " 导出成功", "提示", MessageBoxButtons.OK);
            return true;
        }
        static private void writeData(Excel.Worksheet pWorkSheet, DataGridView pDGV)
        {
            //写入列标题
            for (int i = 0; i <= pDGV.Columns.Count - 1; i++)
            {
                pWorkSheet.Cells[1, i + 1] = pDGV.Columns[i].HeaderCell.Value;

            }
            //写入数值
            for (int r = 0; r <= pDGV.Rows.Count - 1; r++)
            {
                for (int i = 0; i <= pDGV.Columns.Count - 1; i++)
                {
                    pWorkSheet.Cells[r + 2, i + 1] = pDGV.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }

            pWorkSheet.Columns.EntireColumn.AutoFit();//列宽自适应
        }
        #endregion

    }
}
