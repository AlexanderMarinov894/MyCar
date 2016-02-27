using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCar.Data
{
    public class DataProvider
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Database Fields

        private string _ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MyCarDB.accdb";

        #endregion //Database Fields
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Database Commands

        public void Select() 
        {
            //TO DO
        }

        public void Insert(string tableName, string cols, List<object> data) 
        {
            var sb = new StringBuilder();
            foreach (var item in data)
            {
                sb.Append(String.Format("'{0}',", item));
            }
            var values = sb.ToString().TrimEnd(',');

            OleDbConnection conn = new OleDbConnection(_ConnectionString);

            conn.Open();

            OleDbCommand cmd = new OleDbCommand() 
            {
                Connection = conn,
                CommandText = String.Format("INSERT INTO {0} ({1}) values ({2})", tableName, cols, values)
            };

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Update() 
        {
            //TO DO
        }

        public void Delete() 
        {
            //TO DO
        }

        #endregion //Database Commands
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Database Helpers

        public bool IsEmptyTable(string tableName)
        {
            OleDbConnection conn = new OleDbConnection(_ConnectionString);

            conn.Open();

            OleDbCommand cmd = new OleDbCommand()
            {
                Connection = conn,
                CommandText = String.Format("SELECT COUNT(*) FROM [{0}]", tableName)
            };

            int rowCount = (int)cmd.ExecuteScalar();

            conn.Close();

            bool isEmpty = rowCount < 1 ? true : false;

            return isEmpty;
        }

        public DataTable GetTableData(string tableName)
        {
            DataSet data = new DataSet();

            OleDbConnection conn = new OleDbConnection(_ConnectionString);

            conn.Open();

            OleDbCommand cmd = new OleDbCommand()
            {
                Connection = conn,
                CommandText = String.Format("SELECT * FROM [{0}]", tableName)
            };

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(data);

            conn.Close();

            return data.Tables[0];
        }

        #endregion //Database Helpers
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
