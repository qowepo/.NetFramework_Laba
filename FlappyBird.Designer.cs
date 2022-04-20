
namespace Car_Shop
{
    partial class FlappyBird
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_home.BackgroundImage")));
            this.pictureBox_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_home.Location = new System.Drawing.Point(579, 12);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(47, 47);
            this.pictureBox_home.TabIndex = 7;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click_1);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_score.Location = new System.Drawing.Point(13, 11);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(92, 25);
            this.lbl_score.TabIndex = 6;
            this.lbl_score.Text = "Score: 0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(499, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Jump";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.lbl_score);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(657, 459);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(657, 459);
            this.Name = "FlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FlappyBird_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}