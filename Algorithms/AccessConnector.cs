using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Data;
using System.Threading.Tasks;

namespace AccessConnector
{
    class Connect
    {
        public static void ConnectionOpener(string connectionString, string cmdCommand  )
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = connectionString;
            cn.Open();
            string cnString = cn.ConnectionString;
            OleDbCommand cmd = new OleDbCommand(cmdCommand);
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            OleDbDataAdapter da = new OleDbDataAdapter($"{cmd}", $"{cnString}");
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dataTable: dt);
        }
        public static void ConnectionOpener(string connectionString, OleDbCommand cmdCommand)
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = connectionString;
            cn.OpenAsync();
            string cnString = cn.ConnectionString;
            OleDbCommand cmd = new OleDbCommand($"{cmdCommand}");
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            OleDbDataAdapter da = new OleDbDataAdapter($"{cmd}", $"{cnString}");
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dataTable: dt);
        }
        
    }
}
