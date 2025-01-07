
namespace Giftly
{
    partial class AddOccasionDialog
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.occasion_date = new System.Windows.Forms.DateTimePicker();
            this.occasion_name = new System.Windows.Forms.TextBox();
            this.add_occasion_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(92, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Occasion Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(92, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Occasion Date";
            // 
            // occasion_date
            // 
            this.occasion_date.CustomFormat = "yyy-MM-dd";
            this.occasion_date.Location = new System.Drawing.Point(328, 330);
            this.occasion_date.Name = "occasion_date";
            this.occasion_date.Size = new System.Drawing.Size(342, 22);
            this.occasion_date.TabIndex = 3;
            // 
            // occasion_name
            // 
            this.occasion_name.Location = new System.Drawing.Point(328, 280);
            this.occasion_name.Name = "occasion_name";
            this.occasion_name.Size = new System.Drawing.Size(342, 22);
            this.occasion_name.TabIndex = 4;
            // 
            // add_occasion_btn
            // 
            this.add_occasion_btn.BackColor = System.Drawing.Color.Crimson;
            this.add_occasion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_occasion_btn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_occasion_btn.ForeColor = System.Drawing.Color.White;
            this.add_occasion_btn.Location = new System.Drawing.Point(366, 486);
            this.add_occasion_btn.Name = "add_occasion_btn";
            this.add_occasion_btn.Size = new System.Drawing.Size(304, 51);
            this.add_occasion_btn.TabIndex = 5;
            this.add_occasion_btn.Text = "Add Occasion";
            this.add_occasion_btn.UseVisualStyleBackColor = false;
            this.add_occasion_btn.Click += new System.EventHandler(this.add_occasion_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.White;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Location = new System.Drawing.Point(93, 486);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(237, 50);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(96, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 5);
            this.panel1.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Freestyle Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(84, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 71);
            this.label8.TabIndex = 33;
            this.label8.Text = "Giftly";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(92, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Edit Recipient";
            // 
            // AddOccasionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_occasion_btn);
            this.Controls.Add(this.occasion_name);
            this.Controls.Add(this.occasion_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddOccasionDialog";
            this.Text = "AddOccasionDialog";
            this.Load += new System.EventHandler(this.AddOccasionDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker occasion_date;
        private System.Windows.Forms.TextBox occasion_name;
        private System.Windows.Forms.Button add_occasion_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}