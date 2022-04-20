
namespace Car_Shop
{
    partial class AddMark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMark));
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_producer = new System.Windows.Forms.TextBox();
            this.label_producer = new System.Windows.Forms.Label();
            this.textBox_mark = new System.Windows.Forms.TextBox();
            this.label_mark = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.MediumPurple;
            this.button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ok.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ok.Location = new System.Drawing.Point(320, 204);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(91, 28);
            this.button_ok.TabIndex = 20;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.MediumPurple;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_cancel.Location = new System.Drawing.Point(30, 204);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(91, 28);
            this.button_cancel.TabIndex = 19;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox_producer
            // 
            this.textBox_producer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_producer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_producer.Location = new System.Drawing.Point(109, 138);
            this.textBox_producer.Name = "textBox_producer";
            this.textBox_producer.Size = new System.Drawing.Size(302, 26);
            this.textBox_producer.TabIndex = 18;
            // 
            // label_producer
            // 
            this.label_producer.AutoSize = true;
            this.label_producer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_producer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_producer.Location = new System.Drawing.Point(26, 141);
            this.label_producer.Name = "label_producer";
            this.label_producer.Size = new System.Drawing.Size(77, 20);
            this.label_producer.TabIndex = 17;
            this.label_producer.Text = "Producer:";
            // 
            // textBox_mark
            // 
            this.textBox_mark.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_mark.Location = new System.Drawing.Point(109, 81);
            this.textBox_mark.Name = "textBox_mark";
            this.textBox_mark.Size = new System.Drawing.Size(127, 26);
            this.textBox_mark.TabIndex = 16;
            // 
            // label_mark
            // 
            this.label_mark.AutoSize = true;
            this.label_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mark.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_mark.Location = new System.Drawing.Point(26, 84);
            this.label_mark.Name = "label_mark";
            this.label_mark.Size = new System.Drawing.Size(48, 20);
            this.label_mark.TabIndex = 15;
            this.label_mark.Text = "Mark:";
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_id.Location = new System.Drawing.Point(109, 32);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(127, 26);
            this.textBox_id.TabIndex = 14;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_id.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_id.Location = new System.Drawing.Point(26, 35);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(30, 20);
            this.label_id.TabIndex = 13;
            this.label_id.Text = "ID:";
            // 
            // AddMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(437, 248);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_producer);
            this.Controls.Add(this.label_producer);
            this.Controls.Add(this.textBox_mark);
            this.Controls.Add(this.label_mark);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 287);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 287);
            this.Name = "AddMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Mark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_producer;
        private System.Windows.Forms.Label label_producer;
        private System.Windows.Forms.TextBox textBox_mark;
        private System.Windows.Forms.Label label_mark;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
    }
}