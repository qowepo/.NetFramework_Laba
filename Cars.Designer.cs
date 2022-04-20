
namespace Car_Shop
{
    partial class Cars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            this.tabControl_cars = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_home = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.button_site = new System.Windows.Forms.Button();
            this.button_mail = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_adm = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_select = new System.Windows.Forms.Button();
            this.button_all_car_tbl = new System.Windows.Forms.Button();
            this.label_allMark = new System.Windows.Forms.Label();
            this.label_selectMark = new System.Windows.Forms.Label();
            this.listBox_mark = new System.Windows.Forms.ListBox();
            this.trackBar_maxPrice = new System.Windows.Forms.TrackBar();
            this.trackBar_minPrice = new System.Windows.Forms.TrackBar();
            this.label_minP = new System.Windows.Forms.Label();
            this.label_minPrice = new System.Windows.Forms.Label();
            this.label_maxPrice = new System.Windows.Forms.Label();
            this.label_maxP = new System.Windows.Forms.Label();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_maxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_minPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_cars
            // 
            this.tabControl_cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl_cars.Location = new System.Drawing.Point(33, 44);
            this.tabControl_cars.Name = "tabControl_cars";
            this.tabControl_cars.SelectedIndex = 0;
            this.tabControl_cars.Size = new System.Drawing.Size(766, 502);
            this.tabControl_cars.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_home,
            this.ToolStripMenuItem_exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_home
            // 
            this.ToolStripMenuItem_home.Name = "ToolStripMenuItem_home";
            this.ToolStripMenuItem_home.Size = new System.Drawing.Size(55, 21);
            this.ToolStripMenuItem_home.Text = "Home";
            this.ToolStripMenuItem_home.Click += new System.EventHandler(this.ToolStripMenuItem_home_Click);
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(40, 21);
            this.ToolStripMenuItem_exit.Text = "Exit";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exit_Click);
            // 
            // button_site
            // 
            this.button_site.BackColor = System.Drawing.Color.MediumPurple;
            this.button_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_site.Location = new System.Drawing.Point(152, 602);
            this.button_site.Name = "button_site";
            this.button_site.Size = new System.Drawing.Size(308, 52);
            this.button_site.TabIndex = 6;
            this.button_site.Text = "Our Website";
            this.button_site.UseVisualStyleBackColor = false;
            this.button_site.Click += new System.EventHandler(this.button_site_Click);
            // 
            // button_mail
            // 
            this.button_mail.BackColor = System.Drawing.Color.MediumPurple;
            this.button_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mail.Location = new System.Drawing.Point(481, 602);
            this.button_mail.Name = "button_mail";
            this.button_mail.Size = new System.Drawing.Size(308, 52);
            this.button_mail.TabIndex = 7;
            this.button_mail.Text = "E-mail";
            this.button_mail.UseVisualStyleBackColor = false;
            this.button_mail.Click += new System.EventHandler(this.button_mail_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(815, 601);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(436, 52);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add Reviews";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox1.BackgroundImage = global::Car_Shop.Properties.Resources.phone;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(442, 597);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView_adm
            // 
            this.dataGridView_adm.AllowUserToAddRows = false;
            this.dataGridView_adm.AllowUserToDeleteRows = false;
            this.dataGridView_adm.AllowUserToResizeRows = false;
            this.dataGridView_adm.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView_adm.ColumnHeadersHeight = 27;
            this.dataGridView_adm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Mark,
            this.Model,
            this.Price});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_adm.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_adm.Location = new System.Drawing.Point(830, 51);
            this.dataGridView_adm.Name = "dataGridView_adm";
            this.dataGridView_adm.ReadOnly = true;
            this.dataGridView_adm.ShowCellErrors = false;
            this.dataGridView_adm.ShowCellToolTips = false;
            this.dataGridView_adm.ShowEditingIcon = false;
            this.dataGridView_adm.ShowRowErrors = false;
            this.dataGridView_adm.Size = new System.Drawing.Size(421, 305);
            this.dataGridView_adm.StandardTab = true;
            this.dataGridView_adm.TabIndex = 10;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // Mark
            // 
            this.Mark.FillWeight = 220.4724F;
            this.Mark.HeaderText = "Mark";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            this.Mark.Width = 80;
            // 
            // Model
            // 
            this.Model.FillWeight = 59.84252F;
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 90;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.FillWeight = 59.84252F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.MediumPurple;
            this.button_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_select.Location = new System.Drawing.Point(830, 362);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(198, 28);
            this.button_select.TabIndex = 16;
            this.button_select.Text = "Show Selected Models";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_all_car_tbl
            // 
            this.button_all_car_tbl.BackColor = System.Drawing.Color.MediumPurple;
            this.button_all_car_tbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_all_car_tbl.Location = new System.Drawing.Point(1053, 362);
            this.button_all_car_tbl.Name = "button_all_car_tbl";
            this.button_all_car_tbl.Size = new System.Drawing.Size(198, 28);
            this.button_all_car_tbl.TabIndex = 17;
            this.button_all_car_tbl.Text = "Show All Models";
            this.button_all_car_tbl.UseVisualStyleBackColor = false;
            this.button_all_car_tbl.Click += new System.EventHandler(this.button_all_car_tbl_Click);
            // 
            // label_allMark
            // 
            this.label_allMark.AutoSize = true;
            this.label_allMark.BackColor = System.Drawing.Color.MediumPurple;
            this.label_allMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_allMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_allMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_allMark.Location = new System.Drawing.Point(830, 551);
            this.label_allMark.MinimumSize = new System.Drawing.Size(150, 24);
            this.label_allMark.Name = "label_allMark";
            this.label_allMark.Size = new System.Drawing.Size(150, 24);
            this.label_allMark.TabIndex = 25;
            this.label_allMark.Text = "Show All Marks";
            this.label_allMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_allMark.Click += new System.EventHandler(this.label_allMark_Click);
            // 
            // label_selectMark
            // 
            this.label_selectMark.AutoSize = true;
            this.label_selectMark.BackColor = System.Drawing.Color.MediumPurple;
            this.label_selectMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_selectMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_selectMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_selectMark.Location = new System.Drawing.Point(830, 526);
            this.label_selectMark.MinimumSize = new System.Drawing.Size(150, 25);
            this.label_selectMark.Name = "label_selectMark";
            this.label_selectMark.Size = new System.Drawing.Size(150, 25);
            this.label_selectMark.TabIndex = 24;
            this.label_selectMark.Text = "Show Selected Marks";
            this.label_selectMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_selectMark.Click += new System.EventHandler(this.label_selectMark_Click);
            // 
            // listBox_mark
            // 
            this.listBox_mark.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_mark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBox_mark.FormattingEnabled = true;
            this.listBox_mark.ItemHeight = 20;
            this.listBox_mark.Location = new System.Drawing.Point(830, 423);
            this.listBox_mark.Name = "listBox_mark";
            this.listBox_mark.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_mark.Size = new System.Drawing.Size(150, 104);
            this.listBox_mark.TabIndex = 23;
            // 
            // trackBar_maxPrice
            // 
            this.trackBar_maxPrice.BackColor = System.Drawing.Color.MediumPurple;
            this.trackBar_maxPrice.LargeChange = 1;
            this.trackBar_maxPrice.Location = new System.Drawing.Point(1009, 530);
            this.trackBar_maxPrice.Name = "trackBar_maxPrice";
            this.trackBar_maxPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_maxPrice.RightToLeftLayout = true;
            this.trackBar_maxPrice.Size = new System.Drawing.Size(242, 45);
            this.trackBar_maxPrice.TabIndex = 26;
            this.trackBar_maxPrice.Value = 10;
            this.trackBar_maxPrice.Scroll += new System.EventHandler(this.trackBar_maxPrice_Scroll);
            // 
            // trackBar_minPrice
            // 
            this.trackBar_minPrice.BackColor = System.Drawing.Color.MediumPurple;
            this.trackBar_minPrice.LargeChange = 1;
            this.trackBar_minPrice.Location = new System.Drawing.Point(1009, 446);
            this.trackBar_minPrice.Name = "trackBar_minPrice";
            this.trackBar_minPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_minPrice.Size = new System.Drawing.Size(242, 45);
            this.trackBar_minPrice.TabIndex = 28;
            this.trackBar_minPrice.Scroll += new System.EventHandler(this.trackBar_minPrice_Scroll);
            // 
            // label_minP
            // 
            this.label_minP.AutoSize = true;
            this.label_minP.BackColor = System.Drawing.Color.MediumPurple;
            this.label_minP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_minP.Location = new System.Drawing.Point(1009, 423);
            this.label_minP.Name = "label_minP";
            this.label_minP.Size = new System.Drawing.Size(81, 20);
            this.label_minP.TabIndex = 29;
            this.label_minP.Text = "MIN Price:";
            // 
            // label_minPrice
            // 
            this.label_minPrice.AutoSize = true;
            this.label_minPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_minPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_minPrice.Location = new System.Drawing.Point(1091, 423);
            this.label_minPrice.Name = "label_minPrice";
            this.label_minPrice.Size = new System.Drawing.Size(52, 20);
            this.label_minPrice.TabIndex = 30;
            this.label_minPrice.Text = "0 млн";
            // 
            // label_maxPrice
            // 
            this.label_maxPrice.AutoSize = true;
            this.label_maxPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_maxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_maxPrice.Location = new System.Drawing.Point(1093, 507);
            this.label_maxPrice.Name = "label_maxPrice";
            this.label_maxPrice.Size = new System.Drawing.Size(52, 20);
            this.label_maxPrice.TabIndex = 32;
            this.label_maxPrice.Text = "5 млн";
            // 
            // label_maxP
            // 
            this.label_maxP.AutoSize = true;
            this.label_maxP.BackColor = System.Drawing.Color.MediumPurple;
            this.label_maxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_maxP.Location = new System.Drawing.Point(1009, 507);
            this.label_maxP.Name = "label_maxP";
            this.label_maxP.Size = new System.Drawing.Size(87, 20);
            this.label_maxP.TabIndex = 31;
            this.label_maxP.Text = "MAX Price:";
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox_home.BackgroundImage = global::Car_Shop.Properties.Resources.home;
            this.pictureBox_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_home.Location = new System.Drawing.Point(33, 562);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(92, 92);
            this.pictureBox_home.TabIndex = 33;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Car_Shop.Properties.Resources.fon_adm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 687);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.label_maxPrice);
            this.Controls.Add(this.label_maxP);
            this.Controls.Add(this.label_minPrice);
            this.Controls.Add(this.label_minP);
            this.Controls.Add(this.trackBar_minPrice);
            this.Controls.Add(this.trackBar_maxPrice);
            this.Controls.Add(this.label_allMark);
            this.Controls.Add(this.label_selectMark);
            this.Controls.Add(this.listBox_mark);
            this.Controls.Add(this.button_all_car_tbl);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.dataGridView_adm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_mail);
            this.Controls.Add(this.button_site);
            this.Controls.Add(this.tabControl_cars);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 726);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 726);
            this.Name = "Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cars_FormClosed);
            this.Load += new System.EventHandler(this.Cars_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_maxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_minPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_cars;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_home;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
        private System.Windows.Forms.Button button_site;
        private System.Windows.Forms.Button button_mail;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_adm;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_all_car_tbl;
        private System.Windows.Forms.Label label_allMark;
        private System.Windows.Forms.Label label_selectMark;
        private System.Windows.Forms.ListBox listBox_mark;
        private System.Windows.Forms.TrackBar trackBar_maxPrice;
        private System.Windows.Forms.TrackBar trackBar_minPrice;
        private System.Windows.Forms.Label label_minP;
        private System.Windows.Forms.Label label_minPrice;
        private System.Windows.Forms.Label label_maxPrice;
        private System.Windows.Forms.Label label_maxP;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.PictureBox pictureBox_home;
    }
}