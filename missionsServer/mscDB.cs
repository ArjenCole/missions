using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace missions
{
    public static class mscDB
    {
        public static bool connCheck = false;
        private static string Server = "localhost";
        private static string UserID = "root";
        private static string Password = "123456";
        private static string DataBase = "missionsdb1";
        private static MySqlConnection conn = new MySqlConnection();

        public static void SetConfig(string pServer, string pUserID, string pPassword, string pDataBase)
        {
            Server = pServer; UserID = pUserID; Password = pPassword; DataBase = pDataBase;
        }
        public static void SetConnect()
        {
            MySqlConnection tConn;
            try
            {
                tConn = openConnect();
            }
            catch
            {
                connCheck = false;
                return;
            }
            connCheck = true;
            tConn.Close();
        }
        private static MySqlConnection openConnect()
        {
            string connStr = "server=" + Server + ";User Id=" + UserID + ";password=" + Password + ";Database=" + DataBase;
            MySqlConnection rtConn = new MySqlConnection(connStr);
            rtConn.Open();
            return rtConn;
        }

        public static DataTable Search(string pSELECT, string pFROM, string pWHERE = null, string pTableName = "Result_Table")
        {
            string tSQL = "SELECT " + pSELECT + " FROM " + pFROM;
            if (pWHERE != null && pWHERE != "") tSQL += " WHERE " + pWHERE;
            return Search(tSQL, pTableName).Copy();
        }
        public static DataTable Search(string pSQL, string pTableName = "Result_Table")
        {
            MySqlConnection tConn = openConnect();

            MySqlDataAdapter MSDAdap = new MySqlDataAdapter(pSQL, tConn);
            DataTable reDT = new DataTable(pTableName);
            MSDAdap.Fill(reDT);
            tConn.Close();

            return reDT.Copy();
        }

        public static bool Insert(string pSHEET, string pFIELD, string pVALUES)
        {
            string tSQL = "INSERT INTO " + pSHEET + "(" + pFIELD + ") VALUES(" + pVALUES + ")";
            return Exe(tSQL);
        }
        public static bool Delete(string pFROM,string pWHERE)
        {
            string tSQL = "DELETE FROM " + pFROM + " WHERE " + pWHERE;
            return Exe(tSQL);
        }
        public static bool Update(string pSHEET, string pFIELD, string pWHERE)
        {
            string tSQL = "UPDATE " + pSHEET + " SET " + pFIELD + " WHERE " + pWHERE;
            return Exe(tSQL);
        }
        public static bool Exe(string pSQL)
        {
            bool rtBool = false;

            MySqlConnection tConn = openConnect();
            MySqlCommand MSCmd = new MySqlCommand(pSQL, tConn);
            if (MSCmd.ExecuteNonQuery() > 0) rtBool = true;
            tConn.Close();

            return rtBool;
        }

        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="pServer">数据库服务器名称</param>
        /// <param name="pUserID">数据库用户ID</param>
        /// <param name="pPassword">数据库用户密码</param>
        /// <param name="pDataBase">数据库名称</param>
        public static void createDB()
        {
            string connStr = "server=" + Server + ";User Id=" + UserID + ";password=" + Password + ";";
            MySqlConnection conn = new MySqlConnection(connStr);
            string tstr = "CREATE DATABASE " + DataBase + ";";
            MySqlCommand cmd = new MySqlCommand(tstr, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        /// <summary>
        /// 创建数据库表
        /// </summary>
        /// <param name="pServer">数据库服务器名称</param>
        /// <param name="pUserID">数据库用户ID</param>
        /// <param name="pPassword">数据库用户密码</param>
        /// <param name="pDataBase">数据库名称</param>
        public static void createDBtable(Dictionary<string, string> pFields, string pTableName = "newtable", string pPrimaryKey = "Key")
        {
            string connStr = "server=" + Server + ";User Id=" + UserID + ";password=" + Password + ";Database=" + DataBase;

            string createStatement = "CREATE TABLE " + pTableName + "(";
            foreach (string feKey in pFields.Keys)
                createStatement += "`" + feKey + "` " + pFields[feKey] + ",";
            createStatement += "PRIMARY KEY(`" + pPrimaryKey + "`),  KEY `Index` (`" + pPrimaryKey + "`)";
            //createStatement += "PRIMARY KEY(`key`),  KEY `Index` (`key`)";
            createStatement += ")ENGINE=InnoDB DEFAULT CHARSET=utf8;";
            //string alterStatement = "ALTER TABLE Test ADD Field3 Boolean";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                // 建表  
                using (MySqlCommand cmd = new MySqlCommand(createStatement, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                // 改表或者增加行  
                //using (MySqlCommand cmd = new MySqlCommand(alterStatement, conn))
                //{
                //    cmd.ExecuteNonQuery();
                //}
            }
        }

    }
}
