
namespace Car_Shop
{
    partial class Home
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_home_otz = new System.Windows.Forms.Button();
            this.button_home_adm = new System.Windows.Forms.Button();
            this.label_cars = new System.Windows.Forms.Label();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox_play = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_play)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автосалон \"Elegant\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(28, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(706, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Здесь ты сможешь подобрать для себя по - настоящему лучший автомобиль";
            // 
            // button_home_otz
            // 
            this.button_home_otz.BackColor = System.Drawing.Color.Transparent;
            this.button_home_otz.BackgroundImage = global::Car_Shop.Properties.Resources.back;
            this.button_home_otz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_home_otz.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button_home_otz.Location = new System.Drawing.Point(883, 38);
            this.button_home_otz.Name = "button_home_otz";
            this.button_home_otz.Size = new System.Drawing.Size(293, 49);
            this.button_home_otz.TabIndex = 2;
            this.button_home_otz.Text = "Оставить отзыв";
            this.button_home_otz.UseVisualStyleBackColor = false;
            this.button_home_otz.Click += new System.EventHandler(this.button_home_otz_Click);
            // 
            // button_home_adm
            // 
            this.button_home_adm.BackColor = System.Drawing.Color.DimGray;
            this.button_home_adm.BackgroundImage = global::Car_Shop.Properties.Resources.back3;
            this.button_home_adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_home_adm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_home_adm.Location = new System.Drawing.Point(883, 601);
            this.button_home_adm.Name = "button_home_adm";
            this.button_home_adm.Size = new System.Drawing.Size(293, 49);
            this.button_home_adm.TabIndex = 3;
            this.button_home_adm.Text = "Режим администратора";
            this.button_home_adm.UseVisualStyleBackColor = false;
            this.button_home_adm.Click += new System.EventHandler(this.button_home_adm_Click);
            // 
            // label_cars
            // 
            this.label_cars.AutoSize = true;
            this.label_cars.BackColor = System.Drawing.Color.Transparent;
            this.label_cars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_cars.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cars.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_cars.Location = new System.Drawing.Point(47, 605);
            this.label_cars.MinimumSize = new System.Drawing.Size(600, 45);
            this.label_cars.Name = "label_cars";
            this.label_cars.Size = new System.Drawing.Size(600, 45);
            this.label_cars.TabIndex = 1;
            this.label_cars.Text = "Посмотреть все имеющиеся модели...";
            this.label_cars.Click += new System.EventHandler(this.label_cars_Click);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            // 
            // pictureBox_play
            // 
            this.pictureBox_play.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_play.BackgroundImage = global::Car_Shop.Properties.Resources.play;
            this.pictureBox_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_play.Location = new System.Drawing.Point(53, 512);
            this.pictureBox_play.Name = "pictureBox_play";
            this.pictureBox_play.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_play.TabIndex = 4;
            this.pictureBox_play.TabStop = false;
            this.pictureBox_play.Click += new System.EventHandler(this.pictureBox_play_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Car_Shop.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 687);
            this.Controls.Add(this.pictureBox_play);
            this.Controls.Add(this.label_cars);
            this.Controls.Add(this.button_home_adm);
            this.Controls.Add(this.button_home_otz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1240, 726);
            this.MinimumSize = new System.Drawing.Size(1240, 726);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_play)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_home_otz;
        private System.Windows.Forms.Button button_home_adm;
        private System.Windows.Forms.Label label_cars;
      //  private CarShopDataSet carShopDataSet;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.PictureBox pictureBox_play;
        // private CarShopDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
    }
}

