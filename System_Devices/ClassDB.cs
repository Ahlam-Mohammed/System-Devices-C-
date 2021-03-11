using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace System_Devices
{

    
    class ClassDB
    {
        OleDbConnection conn;
        public void connectDB()
        {

            String path = System.Windows.Forms.Application.StartupPath;
            String subPath = path.Substring(0, path.IndexOf(@"\bin") + 1);
            conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ subPath + "project1.accdb";
        }

        public DataSet select_DB(string Query, string TableName)
        {
            OleDbDataAdapter Data_Adapter = new OleDbDataAdapter(Query, conn);
            DataSet ds = new DataSet();
            conn.Open();
            Data_Adapter.Fill(ds, TableName);
            conn.Close();
            return ds;

        }


    }
}
