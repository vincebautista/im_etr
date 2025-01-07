
namespace Giftly
{
    partial class AddRecipientDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.relationship = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.contact_number = new System.Windows.Forms.TextBox();
            this.add_recipient_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.budget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Recipient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Relationship";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact Number";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(251, 75);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(220, 22);
            this.firstname.TabIndex = 7;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(251, 109);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(220, 22);
            this.lastname.TabIndex = 8;
            // 
            // relationship
            // 
            this.relationship.Location = new System.Drawing.Point(251, 136);
            this.relationship.Name = "relationship";
            this.relationship.Size = new System.Drawing.Size(220, 22);
            this.relationship.TabIndex = 9;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(251, 200);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(220, 22);
            this.address.TabIndex = 10;
            // 
            // contact_number
            // 
            this.contact_number.Location = new System.Drawing.Point(275, 229);
            this.contact_number.Name = "contact_number";
            this.contact_number.Size = new System.Drawing.Size(220, 22);
            this.contact_number.TabIndex = 11;
            // 
            // add_recipient_btn
            // 
            this.add_recipient_btn.Location = new System.Drawing.Point(193, 323);
            this.add_recipient_btn.Name = "add_recipient_btn";
            this.add_recipient_btn.Size = new System.Drawing.Size(302, 51);
            this.add_recipient_btn.TabIndex = 12;
            this.add_recipient_btn.Text = "Add Recipient";
            this.add_recipient_btn.UseVisualStyleBackColor = true;
            this.add_recipient_btn.Click += new System.EventHandler(this.add_recipient_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Budget";
            // 
            // budget
            // 
            this.budget.Location = new System.Drawing.Point(241, 172);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(220, 22);
            this.budget.TabIndex = 14;
            // 
            // AddRecipientDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add_recipient_btn);
            this.Controls.Add(this.contact_number);
            this.Controls.Add(this.address);
            this.Controls.Add(this.relationship);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRecipientDialog";
            this.Text = "addRecipientDialog";
            this.Load += new System.EventHandler(this.AddRecipientDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox relationship;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox contact_number;
        private System.Windows.Forms.Button add_recipient_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox budget;
    }
}