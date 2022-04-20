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
using System.IO;
using System.Drawing.Imaging;

namespace Car_Shop
{
    public partial class AddReview : Form
    {
        public AddReview()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (!Protect())
                return;
            string surname = textBox_surname.Text.ToString();
            string name = textBox_name.Text.ToString();
            string mark = cbxMark.Text.ToString();
            string model = cbxModel.Text.ToString();
            string mail = textBox_email.Text.ToString();
            string comment = textBox_comment.Text.ToString();
            string phone = textBox_phone.Text.ToString();
            try
            {
                string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);
                dbConnection.Open();
                int s = PrintID();
                string query = "INSERT INTO [Review] VALUES (" + s.ToString() + ", '" + mark + "', '" + model + 
                    "', '" + surname + "', '" + name + "', '" + comment + "', '" + phone + "', '" + mail + "'" + ")";
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

                if (dbCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Review added successfully!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dbConnection.Close();
            }

            catch
            {
                MessageBox.Show("Add request failed!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
        }

        private int PrintID()
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "SELECT * FROM [Review] ";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();
            int s = 1;
            while (dbReader.Read()) { s++; }
            dbReader.Close();
            dbConnection.Close();

            return s;
        }

        private bool Protect()
        {
            if (cbxMark.Text.Length == 0)
            {
                MessageBox.Show("Please enter Car's Mark!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxModel.Text.Length==0 )
            {
                MessageBox.Show("Please enter Car's Model!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBox_name.Text.Length==0)
            {
                MessageBox.Show("Please enter your Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBox_phone.Text.Length==0 && textBox_email.Text.Length==0)
            {
                MessageBox.Show("Please enter your Phone or E-mail!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void AddReview_Load(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnetion = new OleDbConnection(connectionString);

            dbConnetion.Open();
            string query = "SELECT * FROM Mark ";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnetion);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("DataBase don't have Mark!", "Warning");
                return;
            }

            while (dbReader.Read())
            {
                cbxMark.Items.Add(dbReader["Mark"]);
            }

            dbReader.Close();
            dbConnetion.Close();
        }

        private void cbxMark_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxModel.Items.Clear();
            cbxModel.Text = "";
            pbxCar.Image = null;
            tbxCharact.Clear();
            tbxPrice.Clear();
            tbxAddress.Clear();
            tbxManager.Clear();
            tbxManagerPhone.Clear();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnetion = new OleDbConnection(connectionString);

            dbConnetion.Open();
            string query = "SELECT * FROM Model WHERE Mark LIKE '" + cbxMark.SelectedItem.ToString() + "'";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnetion);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("DataBase don't have Car's Model!", "Warning");
                return;
            }

            while (dbReader.Read())
            {
                cbxModel.Items.Add(dbReader["Model"]);
            }

            dbReader.Close();
            dbConnetion.Close();
        }

        private void cbxModel_SelectedValueChanged(object sender, EventArgs e)
        {

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnetion = new OleDbConnection(connectionString);

            dbConnetion.Open();
            string query = "SELECT * FROM Model WHERE Mark LIKE '" +
                cbxMark.SelectedItem.ToString() + "' AND Model LIKE '" + cbxModel.SelectedItem.ToString() + "'";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnetion);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("DataBase don't have Information about Selected Car!", "Warning");
                return;
            }

            while (dbReader.Read())
            {
                tbxCharact.Text = dbReader["Characteristic"].ToString();
                tbxPrice.Text = dbReader["Price"].ToString();
                tbxAddress.Text = dbReader["Address"].ToString();
                pbxCar.SizeMode = PictureBoxSizeMode.StretchImage;
                pbxCar.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(dbReader["Photo"].ToString())));
            }
            dbReader.Close();



            query = "SELECT * FROM Shop WHERE Address LIKE '" + tbxAddress.Text.ToString() + "'";
            OleDbCommand dbCommand2 = new OleDbCommand(query, dbConnetion);
            OleDbDataReader dbReader2 = dbCommand2.ExecuteReader();

            if (dbReader2.HasRows == false)
            {
                MessageBox.Show("DataBase don't have information about Manager!", "Warning");
                return;
            }

            while (dbReader2.Read())
            {
                tbxManager.Text = dbReader2["Manager"].ToString();
                tbxManagerPhone.Text = dbReader2["Phone"].ToString();
            }

            dbReader2.Close();

            dbConnetion.Close();

        }
    }
}
