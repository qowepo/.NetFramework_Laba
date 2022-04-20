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
    public partial class AddShop : Form
    {
        public AddShop()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text.ToString();
            string manager = textBox_manager.Text.ToString();
            string phone = textBox_phone.Text.ToString();
            string address = textBox_address.Text.ToString();

            if (!Correct(id, manager, phone, address)) { return; }

            try
            {
                string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);
                dbConnection.Open();
                string query = "INSERT INTO [Shop] VALUES (" + id + ", '" + address + "', '" + manager + "', '" + phone + "')";
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

                if (dbCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Car's Shop added successfully!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dbConnection.Close();
            }

            catch
            {
                MessageBox.Show("Add request failed!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
        }

        private bool Correct(string id, string address, string manager, string phone)
        {
            if (!(id.Length > 0 && id.Length < 4))
            {
                MessageBox.Show("Enter correct ID!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 0; i < id.Length; i++)
            {
                if (!(id[i] >= '0' && id[i] <= '9'))
                {
                    MessageBox.Show("Enter correct ID!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (address.Length == 0)
            {
                MessageBox.Show("Enter Address!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (manager.Length == 0)
            {
                MessageBox.Show("Enter Manager!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (phone.Length == 0)
            {
                MessageBox.Show("Enter Phone!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "SELECT id FROM [Shop] WHERE id LIKE " + id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (!(dbReader.HasRows == false))
            {
                MessageBox.Show("ID already buzy!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            dbReader.Close();
            dbConnection.Close();

            return true;
        }
    }
}
