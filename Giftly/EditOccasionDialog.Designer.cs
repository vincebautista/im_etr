
namespace Giftly
{
    partial class EditOccasionDialog
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.edit_occasion_btn = new System.Windows.Forms.Button();
            this.occasion_name = new System.Windows.Forms.TextBox();
            this.occasion_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.White;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(105, 502);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(237, 50);
            this.cancel_btn.TabIndex = 13;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // edit_occasion_btn
            // 
            this.edit_occasion_btn.BackColor = System.Drawing.Color.Crimson;
            this.edit_occasion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_occasion_btn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_occasion_btn.ForeColor = System.Drawing.Color.White;
            this.edit_occasion_btn.Location = new System.Drawing.Point(369, 502);
            this.edit_occasion_btn.Name = "edit_occasion_btn";
            this.edit_occasion_btn.Size = new System.Drawing.Size(237, 50);
            this.edit_occasion_btn.TabIndex = 12;
            this.edit_occasion_btn.Text = "Edit Occasion";
            this.edit_occasion_btn.UseVisualStyleBackColor = false;
            this.edit_occasion_btn.Click += new System.EventHandler(this.edit_occasion_btn_Click);
            // 
            // occasion_name
            // 
            this.occasion_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.occasion_name.Location = new System.Drawing.Point(314, 271);
            this.occasion_name.Name = "occasion_name";
            this.occasion_name.Size = new System.Drawing.Size(292, 22);
            this.occasion_name.TabIndex = 11;
            // 
            // occasion_date
            // 
            this.occasion_date.CustomFormat = "yyy-MM-dd";
            this.occasion_date.Location = new System.Drawing.Point(314, 318);
            this.occasion_date.Name = "occasion_date";
            this.occasion_date.Size = new System.Drawing.Size(292, 22);
            this.occasion_date.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(102, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Occasion Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(102, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Occasion Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(105, 210);
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
            this.label8.Location = new System.Drawing.Point(93, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 71);
            this.label8.TabIndex = 33;
            this.label8.Text = "Giftly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(101, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Edit Ocassion";
            // 
            // EditOccasionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.edit_occasion_btn);
            this.Controls.Add(this.occasion_name);
            this.Controls.Add(this.occasion_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditOccasionDialog";
            this.Text = "EditOccasionDialog";
            this.Load += new System.EventHandler(this.EditOccasionDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button edit_occasion_btn;
        private System.Windows.Forms.TextBox occasion_name;
        private System.Windows.Forms.DateTimePicker occasion_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
    }
}