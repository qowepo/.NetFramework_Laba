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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button_home_adm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin adm = new Admin();
            adm.Show();
        }

        private void button_home_otz_Click(object sender, EventArgs e)
        {
            AddReview rev = new AddReview();
            rev.Show();
        }

           
        private void label_cars_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cars car = new Cars();
            car.Show();
        }

        private void Home_Load(object sender, EventArgs e)  
        {
            pictureBox_play.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox_play_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlappyBird fb = new FlappyBird();
            fb.Show();
        }
    }
}
