
namespace Car_Shop
{
    partial class DeleteCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCar));
            this.label_del = new System.Windows.Forms.Label();
            this.textBox_del = new System.Windows.Forms.TextBox();
            this.button_del = new System.Windows.Forms.Button();
            this.button_non_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_del
            // 
            this.label_del.AutoSize = true;
            this.label_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_del.Location = new System.Drawing.Point(80, 30);
            this.label_del.Name = "label_del";
            this.label_del.Size = new System.Drawing.Size(116, 24);
            this.label_del.TabIndex = 0;
            this.label_del.Text = "Enter Car ID:";
            // 
            // textBox_del
            // 
            this.textBox_del.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_del.Location = new System.Drawing.Point(63, 57);
            this.textBox_del.Name = "textBox_del";
            this.textBox_del.Size = new System.Drawing.Size(150, 22);
            this.textBox_del.TabIndex = 1;
            this.textBox_del.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.Color.MediumPurple;
            this.button_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_del.Location = new System.Drawing.Point(189, 101);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(68, 26);
            this.button_del.TabIndex = 2;
            this.button_del.Text = "Ok";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_non_del
            // 
            this.button_non_del.BackColor = System.Drawing.Color.MediumPurple;
            this.button_non_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_non_del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_non_del.Location = new System.Drawing.Point(21, 101);
            this.button_non_del.Name = "button_non_del";
            this.button_non_del.Size = new System.Drawing.Size(69, 26);
            this.button_non_del.TabIndex = 3;
            this.button_non_del.Text = "Cancel";
            this.button_non_del.UseVisualStyleBackColor = false;
            this.button_non_del.Click += new System.EventHandler(this.button_non_del_Click);
            // 
            // DeleteCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(279, 150);
            this.Controls.Add(this.button_non_del);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.textBox_del);
            this.Controls.Add(this.label_del);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(295, 189);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(295, 189);
            this.Name = "DeleteCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_del;
        private System.Windows.Forms.TextBox textBox_del;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_non_del;
    }
}