using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCar.Forms
{
    public partial class Main : BaseForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //string strProvider = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MyCarDB.accdb";
            //string strSql = "Select * from Vehichles";


            //OleDbConnection OracleConnection = new OleDbConnection(strProvider);

            //// Create a DataAdapter 
            //OleDbDataAdapter OracleDataAdapter = new OleDbDataAdapter(strSql, OracleConnection);

            //// Create the DataSet 
            //DataSet OracleDataSet = new DataSet();

            //// Fill the dataset and give it a table name 
            //OracleDataAdapter.Fill(OracleDataSet, "Vehichles");

            //// Now set the data source using that table name
            //dataGridView1.DataSource = OracleDataSet.Tables["Vehichles"];


            ////con.Close();

            var tableData = this.Database.GetTableData("Vehichles");

            foreach (var row in tableData.Rows)
            {
                string brand = (row as DataRow).ItemArray[1].ToString();
                string model = (row as DataRow).ItemArray[2].ToString();

                treeViewVehichles.Nodes["Vehichles"].Nodes.Add(String.Format("{0} {1}", brand, model));
            }
        }
    }
}
