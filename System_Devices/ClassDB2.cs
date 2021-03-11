using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace System_Devices
{
    class ClassDB2
    {
        OleDbConnection con;
        string AppPath = System.Windows.Forms.Application.StartupPath;
        public void ConnectDb()
        {
            string subPath = AppPath.Substring(0, AppPath.LastIndexOf(@"\bin") + 1);
            con = new OleDbConnection();

            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+subPath+"project1.accdb";



        }
        public DataSet SetectDB(string Query, string TableName)
        {
            
           OleDbDataAdapter dp = new OleDbDataAdapter(Query, con);
            DataSet ds = new DataSet();
            con.Open();
            dp.Fill(ds, TableName);
            con.Close();
            return ds;
        }

        public void Insert_Update_DeleteDB(string Query)
        {
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = Query;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}