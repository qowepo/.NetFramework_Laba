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

namespace Car_Shop
{
    public partial class Reviews : Form
    {
        public Reviews()
        {
            InitializeComponent();
        }

        private void Reviews_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnetion = new OleDbConnection(connectionString);

            dbConnetion.Open();
            string query = "SELECT * FROM Review";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnetion);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
                       MessageBox.Show("DataBase don't have Reviews!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            else
            {
                while (dbReader.Read())
                {
                    dataGridView1.Rows.Add(dbReader["id"], dbReader["Mark"],
                        dbReader["Model"], dbReader["Surname"], dbReader["Name"],
                        dbReader["Comment"], dbReader["Phone"], dbReader["Email"]);
                }
            }
            dbReader.Close();
            dbConnetion.Close();

        }
    }
}
