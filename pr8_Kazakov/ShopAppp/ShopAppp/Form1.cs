using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ShopAppp
{
    public partial class Form1 : Form
    {
        OleDbConnection Connection = new OleDbConnection(Properties.Settings.Default.DB_ShopConnectionString);
        public Form1()
        {
            InitializeComponent();
            BN_Data.BindingSource = BS_Data;
            Dgv_Data.DataSource = BS_Data;
        }

        private void openBD_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = Connection.CreateCommand();
            OleDbDataAdapter DA = new OleDbDataAdapter(cmd);
            DataTable DT = new DataTable();
            cmd.CommandText = "SELECT * FROM Tovar";
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
            DA.Fill(DT);
            BS_Data.DataSource = DT;
        }

        private void closeBD_Click(object sender, EventArgs e)
        {
            BS_Data.DataSource = null;
        }
    }
}
