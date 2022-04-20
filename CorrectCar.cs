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
    public partial class CorrectCar : Form
    {
        public CorrectCar()
        {
            InitializeComponent();
        }

        private bool ProtectId()
        {
            if (!(textBox_id.Text.Length > 0 && textBox_id.Text.Length < 4))
            {
                MessageBox.Show("Enter correct ID!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 0; i < textBox_id.Text.Length; i++)
            {
                if (!(textBox_id.Text[i] >= '0' && textBox_id.Text[i] <= '9'))
                {
                    MessageBox.Show("Enter correct ID!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "SELECT id FROM [Model] WHERE id LIKE " + textBox_id.Text;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("DataBase don't have this ID !", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            dbReader.Close();
            dbConnection.Close();

            return true;
        }
        private bool Protect()
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Please add photo!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBox_mark.Text == "" && comboBox_mark.Text == "")
            {
                MessageBox.Show("Please enter Mark and Model!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBox_price.Text == "" && textBox_charact.Text == "")
            {
                MessageBox.Show("Please enter Price and Characteristic!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void button_idOk_Click(object sender, EventArgs e)
        {
            if (!ProtectId())
                return;

            button_idOk.Visible = false;
            textBox_charact.Visible = true;
            textBox_model.Visible = true;
            textBox_price.Visible = true;
            comboBox_mark.Visible = true;
            comboBox_address.Visible = true;
            label_address.Visible = true;
            label4.Visible = true;
            label_mark.Visible = true;
            label_model.Visible = true;
            label_price.Visible = true;
            button_ok.Visible = true;
            button_photo.Visible = true;


            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "SELECT * FROM [Model] WHERE id LIKE " + textBox_id.Text.ToString();
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            while (dbReader.Read())
            {
                comboBox_mark.Text = dbReader["Mark"].ToString();
                comboBox_address.Text = dbReader["Address"].ToString();
                textBox_id.Enabled = false;
                textBox_model.Text = dbReader["Model"].ToString();
                textBox_price.Text = dbReader["Price"].ToString();
                textBox_charact.Text = dbReader["Characteristic"].ToString();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(dbReader["Photo"].ToString())));
                pictureBox.Visible = true;
            }

            dbReader.Close();
            dbConnection.Close();

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (!Protect())
                return;
            try
            {

                string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);
                dbConnection.Open();
                string query = "UPDATE Model SET Mark= '" + comboBox_mark.Text + "', Model= '" + 
                    textBox_model.Text + "', Characteristic= '" + textBox_charact.Text + "', Price= " +
                    textBox_price.Text + ", Address= '" + comboBox_address.Text + "', Photo = '" + 
                    ImageToBase64(pictureBox.Image, ImageFormat.Jpeg) + "' WHERE id =" + textBox_id.Text;
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

                if (dbCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Car's Model successfully Correct!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dbConnection.Close();
            }
            catch
            {
                MessageBox.Show("Correct request failed!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Hide();

        }

        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void button_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP; *.JPG; *.GIF; *.PNG)|*.BMP; *.JPG; *.GIF; *.PNG| All files(*.*)|*.*";
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            try
            {
                pictureBox.Image = new Bitmap(ofd.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                MessageBox.Show("The selected file cannot be opened!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CorrectCar_Load(object sender, EventArgs e)
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
                comboBox_mark.Items.Add(dbReader["Mark"]);
            }

            dbReader.Close();

            string query2 = "SELECT * FROM Shop ";
            OleDbCommand dbCommand2 = new OleDbCommand(query2, dbConnetion);
            OleDbDataReader dbReader2 = dbCommand2.ExecuteReader();

            if (dbReader2.HasRows == false)
            {
                MessageBox.Show("DataBase don't have Shop!", "Warning");
                return;
            }

            while (dbReader2.Read())
            {
                comboBox_address.Items.Add(dbReader2["Address"]);
            }

            dbReader2.Close();

            dbConnetion.Close();

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
