
namespace Giftly
{
    partial class EditGiftIdea
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
            this.gift_name = new System.Windows.Forms.TextBox();
            this.edit_gift_idea = new System.Windows.Forms.Button();
            this.occasions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gift_name
            // 
            this.gift_name.Location = new System.Drawing.Point(305, 269);
            this.gift_name.Name = "gift_name";
            this.gift_name.Size = new System.Drawing.Size(304, 22);
            this.gift_name.TabIndex = 9;
            // 
            // edit_gift_idea
            // 
            this.edit_gift_idea.BackColor = System.Drawing.Color.Crimson;
            this.edit_gift_idea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_gift_idea.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_gift_idea.ForeColor = System.Drawing.Color.White;
            this.edit_gift_idea.Location = new System.Drawing.Point(305, 449);
            this.edit_gift_idea.Name = "edit_gift_idea";
            this.edit_gift_idea.Size = new System.Drawing.Size(304, 51);
            this.edit_gift_idea.TabIndex = 8;
            this.edit_gift_idea.Text = "Edit Gift Idea";
            this.edit_gift_idea.UseVisualStyleBackColor = false;
            this.edit_gift_idea.Click += new System.EventHandler(this.edit_gift_idea_Click);
            // 
            // occasions
            // 
            this.occasions.FormattingEnabled = true;
            this.occasions.Location = new System.Drawing.Point(305, 329);
            this.occasions.Name = "occasions";
            this.occasions.Size = new System.Drawing.Size(304, 24);
            this.occasions.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(122, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gift Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(124, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 5);
            this.panel1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Freestyle Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(112, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 71);
            this.label8.TabIndex = 36;
            this.label8.Text = "Giftly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(120, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Edit Gift Ideas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(122, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Occasions";
            // 
            // EditGiftIdea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 641);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gift_name);
            this.Controls.Add(this.edit_gift_idea);
            this.Controls.Add(this.occasions);
            this.Controls.Add(this.label2);
            this.Name = "EditGiftIdea";
            this.Text = "EditGiftIdea";
            this.Load += new System.EventHandler(this.EditGiftIdea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gift_name;
        private System.Windows.Forms.Button edit_gift_idea;
        private System.Windows.Forms.ComboBox occasions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}