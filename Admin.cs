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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void PrintMark()
        {
            listBox_mark.Items.Clear();
            dataGridView_mark.Rows.Clear();
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnetion = new OleDbConnection(connectionString);

            dbConnetion.Open();
            string query = "SELECT * FROM Mark ";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnetion);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("DataBase don't have Mark!", "Warning");
            }
            else
            {
                while (dbReader.Read())
                {
                    listBox_mark.Items.Add(dbReader["Mark"]);
                    dataGridView_mark.Rows.Add(dbReader["id"], dbReader["Mark"],
                        dbReader["Producer"]);
                }
            }
            
            dbReader.Close();
            dbConnetion.Close();
        }
        private void PrintCar (string mark)
        {
            dataGridView_adm.Rows.Clear();
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnetion = new OleDbConnection(connectionString);

            dbConnetion.Open();
            string query = "SELECT id, Mark, Model, Characteristic, Price FROM Model " + mark;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnetion);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("DataBase don't have Models of this Mark!", "Warning");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView_adm.Rows.Add(dbReader["id"], dbReader["Mark"], 
                        dbReader["Model"], dbReader["Characteristic"], dbReader["Price"]);
                }
            }
            dbReader.Close();
            dbConnetion.Close();
        }

        private void PrintShop()
        {
            dataGridView_shop.Rows.Clear();
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnetion = new OleDbConnection(connectionString);

            dbConnetion.Open();
            string query = "SELECT * FROM Shop";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnetion);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("DataBase don't have Shop!", "Warning");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView_shop.Rows.Add(dbReader["id"], dbReader["Address"],
                        dbReader["Manager"], dbReader["Phone"]);
                }
            }
            dbReader.Close();
            dbConnetion.Close();
        }

        private void ToolStripMenuItem_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void Admin_Load(object sender, EventArgs e)
        {
            string mark = "";
            PrintCar(mark);
            PrintMark();
            PrintShop();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddCar add = new AddCar();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteCar del = new DeleteCar();
            del.Show();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string mark = "";
            PrintCar(mark);
            PrintMark();
            PrintShop();
        }

        private void label_rev_Click(object sender, EventArgs e)
        {
            Reviews rev = new Reviews();
            rev.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reviews rev = new Reviews();
            rev.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string mark = "";
            PrintCar(mark);
        }

        private void label_selectMark_Click(object sender, EventArgs e)
        {
            int count = listBox_mark.SelectedItems.Count;
            string mark = "WHERE ";
            for (int i = 0; i < count; i++)
            {
                mark += " Mark LIKE '" + listBox_mark.SelectedItems[i].ToString() + "' OR";
            }
            mark = mark.Remove(mark.Length - 2);
            listBox_mark.ClearSelected();
           PrintCar(mark);
        }

        private void label_add_mark_Click(object sender, EventArgs e)
        {
            AddMark add_mark = new AddMark();
            add_mark.Show();
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_correct_Click(object sender, EventArgs e)
        {
            CorrectCar cor = new CorrectCar();
            cor.Show();
        }

        private void label_add_shop_Click(object sender, EventArgs e)
        {
            AddShop add_shop = new AddShop();
            add_shop.Show();
        }
    }
}
