
namespace Car_Shop
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_home = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.button_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label_rewiews = new System.Windows.Forms.Label();
            this.label_add_mark = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Characteristic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_adm = new System.Windows.Forms.DataGridView();
            this.Producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_mark = new System.Windows.Forms.DataGridView();
            this.label_rev = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox_mark = new System.Windows.Forms.ListBox();
            this.label_selectMark = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.button_correct = new System.Windows.Forms.Button();
            this.label_add_shop = new System.Windows.Forms.Label();
            this.dataGridView_shop = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_shop)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_home,
            this.ToolStripMenuItem_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1284, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_home
            // 
            this.ToolStripMenuItem_home.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItem_home.Name = "ToolStripMenuItem_home";
            this.ToolStripMenuItem_home.Size = new System.Drawing.Size(55, 21);
            this.ToolStripMenuItem_home.Text = "Home";
            this.ToolStripMenuItem_home.Click += new System.EventHandler(this.ToolStripMenuItem_home_Click);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(40, 21);
            this.ToolStripMenuItem_Exit.Text = "Exit";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.MediumPurple;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(408, 596);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(214, 58);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Add New Car\'s Model";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(638, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete Car\'s Model";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.MediumPurple;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update.Location = new System.Drawing.Point(913, 596);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(347, 58);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "Update Database Connection";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label_rewiews
            // 
            this.label_rewiews.AutoSize = true;
            this.label_rewiews.BackColor = System.Drawing.Color.MediumPurple;
            this.label_rewiews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_rewiews.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rewiews.Location = new System.Drawing.Point(1108, 834);
            this.label_rewiews.Name = "label_rewiews";
            this.label_rewiews.Size = new System.Drawing.Size(172, 29);
            this.label_rewiews.TabIndex = 12;
            this.label_rewiews.Text = "Show Reviews";
            // 
            // label_add_mark
            // 
            this.label_add_mark.AutoSize = true;
            this.label_add_mark.BackColor = System.Drawing.Color.MediumPurple;
            this.label_add_mark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_add_mark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_add_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_mark.Location = new System.Drawing.Point(300, 482);
            this.label_add_mark.Name = "label_add_mark";
            this.label_add_mark.Size = new System.Drawing.Size(126, 22);
            this.label_add_mark.TabIndex = 17;
            this.label_add_mark.Text = "Add New Mark...";
            this.label_add_mark.Click += new System.EventHandler(this.label_add_mark_Click);
            // 
            // Price
            // 
            this.Price.FillWeight = 59.84252F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Characteristic
            // 
            this.Characteristic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Characteristic.FillWeight = 59.84252F;
            this.Characteristic.HeaderText = "Characteristic";
            this.Characteristic.Name = "Characteristic";
            this.Characteristic.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.FillWeight = 59.84252F;
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 70;
            // 
            // Mark
            // 
            this.Mark.FillWeight = 220.4724F;
            this.Mark.HeaderText = "Mark";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            this.Mark.Width = 70;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 70;
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
            this.Characteristic,
            this.Price});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_adm.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_adm.Location = new System.Drawing.Point(26, 44);
            this.dataGridView_adm.Name = "dataGridView_adm";
            this.dataGridView_adm.ReadOnly = true;
            this.dataGridView_adm.ShowCellErrors = false;
            this.dataGridView_adm.ShowCellToolTips = false;
            this.dataGridView_adm.ShowEditingIcon = false;
            this.dataGridView_adm.ShowRowErrors = false;
            this.dataGridView_adm.Size = new System.Drawing.Size(906, 306);
            this.dataGridView_adm.StandardTab = true;
            this.dataGridView_adm.TabIndex = 0;
            // 
            // Producer
            // 
            this.Producer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producer.HeaderText = "Producer";
            this.Producer.Name = "Producer";
            this.Producer.ReadOnly = true;
            // 
            // Marks
            // 
            this.Marks.HeaderText = "Marks";
            this.Marks.Name = "Marks";
            this.Marks.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 60;
            // 
            // dataGridView_mark
            // 
            this.dataGridView_mark.AllowUserToAddRows = false;
            this.dataGridView_mark.AllowUserToDeleteRows = false;
            this.dataGridView_mark.AllowUserToResizeRows = false;
            this.dataGridView_mark.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView_mark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Marks,
            this.Producer});
            this.dataGridView_mark.Location = new System.Drawing.Point(26, 356);
            this.dataGridView_mark.Name = "dataGridView_mark";
            this.dataGridView_mark.ReadOnly = true;
            this.dataGridView_mark.Size = new System.Drawing.Size(401, 149);
            this.dataGridView_mark.TabIndex = 16;
            // 
            // label_rev
            // 
            this.label_rev.AutoSize = true;
            this.label_rev.BackColor = System.Drawing.Color.MediumPurple;
            this.label_rev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_rev.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rev.Location = new System.Drawing.Point(960, 248);
            this.label_rev.MinimumSize = new System.Drawing.Size(300, 33);
            this.label_rev.Name = "label_rev";
            this.label_rev.Size = new System.Drawing.Size(300, 33);
            this.label_rev.TabIndex = 18;
            this.label_rev.Text = "Show Reviews";
            this.label_rev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_rev.Click += new System.EventHandler(this.label_rev_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Car_Shop.Properties.Resources.adm_gif;
            this.pictureBox1.Location = new System.Drawing.Point(960, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 225);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBox_mark
            // 
            this.listBox_mark.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_mark.FormattingEnabled = true;
            this.listBox_mark.ItemHeight = 18;
            this.listBox_mark.Location = new System.Drawing.Point(960, 294);
            this.listBox_mark.Name = "listBox_mark";
            this.listBox_mark.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_mark.Size = new System.Drawing.Size(300, 130);
            this.listBox_mark.TabIndex = 20;
            // 
            // label_selectMark
            // 
            this.label_selectMark.AutoSize = true;
            this.label_selectMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_selectMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_selectMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_selectMark.Location = new System.Drawing.Point(960, 399);
            this.label_selectMark.MinimumSize = new System.Drawing.Size(150, 25);
            this.label_selectMark.Name = "label_selectMark";
            this.label_selectMark.Size = new System.Drawing.Size(150, 25);
            this.label_selectMark.TabIndex = 21;
            this.label_selectMark.Text = "Show Selected Marks";
            this.label_selectMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_selectMark.Click += new System.EventHandler(this.label_selectMark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1110, 399);
            this.label1.MinimumSize = new System.Drawing.Size(150, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Show All Marks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox_home.BackgroundImage = global::Car_Shop.Properties.Resources.home;
            this.pictureBox_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_home.Location = new System.Drawing.Point(26, 560);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(94, 94);
            this.pictureBox_home.TabIndex = 34;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // button_correct
            // 
            this.button_correct.BackColor = System.Drawing.Color.MediumPurple;
            this.button_correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_correct.Location = new System.Drawing.Point(178, 596);
            this.button_correct.Name = "button_correct";
            this.button_correct.Size = new System.Drawing.Size(214, 58);
            this.button_correct.TabIndex = 35;
            this.button_correct.Text = "Correct Car\'s Model";
            this.button_correct.UseVisualStyleBackColor = false;
            this.button_correct.Click += new System.EventHandler(this.button_correct_Click);
            // 
            // label_add_shop
            // 
            this.label_add_shop.AutoSize = true;
            this.label_add_shop.BackColor = System.Drawing.Color.MediumPurple;
            this.label_add_shop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_add_shop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_add_shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_shop.Location = new System.Drawing.Point(802, 482);
            this.label_add_shop.Name = "label_add_shop";
            this.label_add_shop.Size = new System.Drawing.Size(129, 22);
            this.label_add_shop.TabIndex = 37;
            this.label_add_shop.Text = "Add New Shop...";
            this.label_add_shop.Click += new System.EventHandler(this.label_add_shop_Click);
            // 
            // dataGridView_shop
            // 
            this.dataGridView_shop.AllowUserToAddRows = false;
            this.dataGridView_shop.AllowUserToDeleteRows = false;
            this.dataGridView_shop.AllowUserToResizeRows = false;
            this.dataGridView_shop.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView_shop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_shop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Address,
            this.Manager,
            this.Phone});
            this.dataGridView_shop.Location = new System.Drawing.Point(433, 356);
            this.dataGridView_shop.Name = "dataGridView_shop";
            this.dataGridView_shop.ReadOnly = true;
            this.dataGridView_shop.Size = new System.Drawing.Size(499, 149);
            this.dataGridView_shop.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Manager
            // 
            this.Manager.HeaderText = "Manager";
            this.Manager.Name = "Manager";
            this.Manager.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 120;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = global::Car_Shop.Properties.Resources.fon_adm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 687);
            this.Controls.Add(this.label_add_shop);
            this.Controls.Add(this.dataGridView_shop);
            this.Controls.Add(this.button_correct);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_selectMark);
            this.Controls.Add(this.listBox_mark);
            this.Controls.Add(this.label_rev);
            this.Controls.Add(this.label_add_mark);
            this.Controls.Add(this.dataGridView_mark);
            this.Controls.Add(this.label_rewiews);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView_adm);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 726);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 726);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_shop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_home;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label_rewiews;
        private System.Windows.Forms.Label label_add_mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Characteristic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView dataGridView_adm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridView dataGridView_mark;
        private System.Windows.Forms.Label label_rev;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox_mark;
        private System.Windows.Forms.Label label_selectMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.Button button_correct;
        private System.Windows.Forms.Label label_add_shop;
        private System.Windows.Forms.DataGridView dataGridView_shop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}