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
    public partial class AddMark : Form
    {
        public AddMark()
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
            string mark = textBox_mark.Text.ToString();
            string producer = textBox_producer.Text.ToString();

            if (!Correct(id, mark, producer))  {  return; }

            try
            {
                string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);
                dbConnection.Open();
                string query = "INSERT INTO [Mark] VALUES (" + id + ", '" + mark + "', '" + producer + "')";
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

                if (dbCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Car's Mark added successfully!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dbConnection.Close();
            }

            catch
            {
                MessageBox.Show("Add request failed!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();

        }

        private bool Correct(string id, string mark, string producer)
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

            if (mark.Length == 0) 
            {
                MessageBox.Show("Enter MARK!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (producer.Length == 0)
            {
                MessageBox.Show("Enter PRODUCER!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "SELECT id, Mark FROM [Mark] WHERE id LIKE " + id + " OR Mark LIKE '" + mark + "'";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (!(dbReader.HasRows == false))
            {
                MessageBox.Show("ID or MARK already buzy!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            dbReader.Close();
            dbConnection.Close();


            return true;
        }
    }
}
