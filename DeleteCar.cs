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
    public partial class DeleteCar : Form
    {
        public DeleteCar()
        {
            InitializeComponent();
        }

        private void button_del_Click(object sender, EventArgs e)
        {

            if (!(textBox_del.Text.Length > 0 && textBox_del.Text.Length < 4))
            {
                MessageBox.Show("Enter correct id!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_del.Clear();
                return;
            }

            for (int i = 0; i < textBox_del.Text.Length; i++)
            {
                if (!(textBox_del.Text[i] >= '0' && textBox_del.Text[i] <= '9'))
                {
                    MessageBox.Show("Enter correct id!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_del.Clear();
                    return;
                }
            }


            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            try
            {
                string query = "DELETE FROM [Model] WHERE id = " + textBox_del.Text;
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                string IdCarPhotoDelete = textBox_del.Text;

                if (dbCommand.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Данного ID нет в базе!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_del.Clear();
                    dbConnection.Close();
                    return;
                }
                MessageBox.Show("Car successfull delete!" + "\n"
                    + "Ubdate connect with Database!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Erorr, car don't delete!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dbConnection.Close();
            this.Hide();
            return;

        }

        private void button_non_del_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
