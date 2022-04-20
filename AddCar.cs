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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (!Protect())   { return; }
           
            string id = textBox_id.Text.ToString();
            string mark = comboBox_mark.Text.ToString();
            string address = comboBox_address.Text.ToString();
            string model = textBox_model.Text.ToString();
            string price = textBox_price.Text.ToString();
            string characteristic = textBox_charact.Text.ToString();
            string photo = ImageToBase64(pictureBox.Image, ImageFormat.Jpeg);

            try
            {
                string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);
                dbConnection.Open();
                string query = "INSERT INTO [Model] VALUES (" + id + ", '" + mark + "', '" + model + "', '" + characteristic + "', " +
                     price + ", '" + address + "', '" + photo + "')";
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

                if (dbCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Car's Model added successfully!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dbConnection.Close();
            }

            catch
            {
                MessageBox.Show("Add request failed!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
        }


        private bool Protect()
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

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            string query = "SELECT id FROM [Model] WHERE id LIKE " + textBox_id.Text;
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

        private void AddCar_Load(object sender, EventArgs e)
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


            string query2 = "SELECT Address FROM Shop";
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
       
    }
}
