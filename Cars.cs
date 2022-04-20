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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void ToolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrintCar(string mark)
        {
            try
            {
                tabControl_cars.TabPages.Clear();
                string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
                OleDbConnection dbConnetion = new OleDbConnection(connectionString);

                dbConnetion.Open();
                string query = "SELECT * FROM Model " + mark;
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnetion);
                OleDbDataReader dbReader = dbCommand.ExecuteReader();

                if (dbReader.HasRows == false)
                {
                    TabPage model = new TabPage("It's empty");
                    PictureBox car_photo = new PictureBox();
                    car_photo.Width = 765;
                    car_photo.Height = 477;
                    car_photo.SizeMode = PictureBoxSizeMode.Zoom;
                    car_photo.Image = new Bitmap(Car_Shop.Properties.Resources.empty);
                    model.Controls.Add(car_photo);
                    tabControl_cars.Controls.Add(model);
                    dbReader.Close();
                    dbConnetion.Close();
                    return;
                }


                while (dbReader.Read())
                {
                    string car_mark = dbReader["Mark"].ToString() + " " + dbReader["Model"].ToString();
                    TabPage model = new TabPage(car_mark);

                    PictureBox car_photo = new PictureBox();
                    car_photo.Width = 765;
                    car_photo.Height = 510;
                    car_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                    car_photo.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(dbReader["Photo"].ToString())));
                    model.BackColor = Color.MediumPurple;

                    Label newLabel1 = new Label();
                    newLabel1.Height = 22;
                    newLabel1.Width = 1000;
                    newLabel1.ForeColor = Color.White;
                    newLabel1.Font = new System.Drawing.Font("Tobota", 12, FontStyle.Regular);
                    newLabel1.Text = dbReader["Mark"] + " " + dbReader["Model"] + "        " +
                         "Address Shop: "+ dbReader["Address"] + "        Price: " + dbReader["Price"];

                    model.Controls.Add(newLabel1);
                    model.Controls.Add(car_photo);
                    tabControl_cars.Controls.Add(model);
                }
     
                dbReader.Close();
                dbConnetion.Close();
            }
            catch
            {
                MessageBox.Show("Uncorrect CHOISE!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintCarTbl(string mark)
        {
            try
            {
                listBox_mark.Items.Clear();
                dataGridView_adm.Rows.Clear();
                string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=CarShop.mdb";
                OleDbConnection dbConnetion = new OleDbConnection(connectionString);

                dbConnetion.Open();
                string query = "SELECT id, Mark, Model, Price FROM Model " + mark;
                string query2 = "SELECT * FROM Mark ";
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnetion);
                OleDbDataReader dbReader = dbCommand.ExecuteReader();
                OleDbCommand dbCommand2 = new OleDbCommand(query2, dbConnetion);
                OleDbDataReader dbReader2 = dbCommand2.ExecuteReader();

                while (dbReader2.Read())
                {
                    listBox_mark.Items.Add(dbReader2["Mark"]);
                }
                dbReader2.Close();

                if (dbReader.HasRows == false)
                {
                    tabControl_cars.BackColor = Color.Black;
                    dbReader.Close();
                    dbConnetion.Close();
                    return;
                }
                
                while (dbReader.Read())
                {

                    dataGridView_adm.Rows.Add(dbReader["id"], dbReader["Mark"],
                        dbReader["Model"], dbReader["Price"]);
                }
               
                dbReader.Close();
                dbConnetion.Close();
            }
            catch
            {
                MessageBox.Show("Uncorrect work DataBase!", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            string mark = "";
            PrintCar(mark);
            PrintCarTbl(mark);
            tabControl_cars.BackColor = Color.MediumPurple;

        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            AddReview rev = new AddReview();
            rev.Show();
        }

        private void button_mail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:nikulinn3349@gmail.com");
        }

        private void button_site_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://auto.fm/ratings/elegant-avto");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-call:89087457823");
        }

     

        private void button_select_Click(object sender, EventArgs e)
        {
            trackBar_minPrice.Value = 0;
            label_minPrice.Text = "0 млн";
            trackBar_maxPrice.Value = 10;
            label_maxPrice.Text = "5 млн";
            string mark = "WHERE ";
            int count = dataGridView_adm.Rows.Count;
            for (int i = 0; i < count; i++) 
            {
                if(dataGridView_adm.Rows[i].Selected)
                {
                    mark += " id LIKE " + dataGridView_adm.Rows[i].Cells[0].Value.ToString()+" OR";
                }
            }
            mark = mark.Remove(mark.Length - 2);
            
            PrintCar(mark);
        }

        private void button_all_car_tbl_Click(object sender, EventArgs e)
        {
            trackBar_minPrice.Value = 0;
            label_minPrice.Text = "0 млн";
            trackBar_maxPrice.Value = 10;
            label_maxPrice.Text = "5 млн";
            string mark = "";
            PrintCar(mark);
            PrintCarTbl(mark);
            
        }

        private void label_selectMark_Click(object sender, EventArgs e)
        {
            trackBar_minPrice.Value = 0;
            label_minPrice.Text = "0 млн";
            trackBar_maxPrice.Value = 10;
            label_maxPrice.Text = "5 млн";
            int count = listBox_mark.SelectedItems.Count;
            string mark = "WHERE ";
            for (int i = 0; i < count; i++)
            {
                mark += " Mark LIKE '" + listBox_mark.SelectedItems[i].ToString() + "' OR";
            }
            mark = mark.Remove(mark.Length - 2);
            listBox_mark.ClearSelected();
            PrintCar(mark);
            PrintCarTbl(mark);
        }

        private void label_allMark_Click(object sender, EventArgs e)
        {
            trackBar_minPrice.Value = 0;
            label_minPrice.Text = "0 млн";
            trackBar_maxPrice.Value = 10;
            label_maxPrice.Text = "5 млн";
            string mark = "";
            PrintCar(mark);
            PrintCarTbl(mark);
        }

        private void trackBar_minPrice_Scroll(object sender, EventArgs e)
        {
            label_minPrice.Text = (trackBar_minPrice.Value*0.5).ToString() + " млн";
            string mark = "WHERE Price >= " + (trackBar_minPrice.Value * 500000).ToString() +
                " AND Price <= " + (trackBar_maxPrice.Value * 500000).ToString();
            PrintCar(mark);
            PrintCarTbl(mark);
        }

        private void trackBar_maxPrice_Scroll(object sender, EventArgs e)
        {
            label_maxPrice.Text = (trackBar_maxPrice.Value*0.5).ToString() + " млн";
            string mark = "WHERE Price >= " + (trackBar_minPrice.Value * 500000).ToString() +
                " AND Price <= " + (trackBar_maxPrice.Value * 500000).ToString();
            PrintCar(mark);
            PrintCarTbl(mark);
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }

        private void Cars_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
