
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(156, 311);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(237, 50);
            this.cancel_btn.TabIndex = 13;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // edit_occasion_btn
            // 
            this.edit_occasion_btn.Location = new System.Drawing.Point(407, 311);
            this.edit_occasion_btn.Name = "edit_occasion_btn";
            this.edit_occasion_btn.Size = new System.Drawing.Size(237, 50);
            this.edit_occasion_btn.TabIndex = 12;
            this.edit_occasion_btn.Text = "Edit Occasion";
            this.edit_occasion_btn.UseVisualStyleBackColor = true;
            this.edit_occasion_btn.Click += new System.EventHandler(this.edit_occasion_btn_Click);
            // 
            // occasion_name
            // 
            this.occasion_name.Location = new System.Drawing.Point(399, 149);
            this.occasion_name.Name = "occasion_name";
            this.occasion_name.Size = new System.Drawing.Size(246, 22);
            this.occasion_name.TabIndex = 11;
            // 
            // occasion_date
            // 
            this.occasion_date.CustomFormat = "yyy-MM-dd";
            this.occasion_date.Location = new System.Drawing.Point(392, 190);
            this.occasion_date.Name = "occasion_date";
            this.occasion_date.Size = new System.Drawing.Size(253, 22);
            this.occasion_date.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Occasion Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Occasion Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Edit Occasion";
            // 
            // EditOccasionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.edit_occasion_btn);
            this.Controls.Add(this.occasion_name);
            this.Controls.Add(this.occasion_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}