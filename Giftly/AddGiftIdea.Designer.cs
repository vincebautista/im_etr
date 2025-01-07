
namespace Giftly
{
    partial class AddGiftIdea
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
            this.occasions = new System.Windows.Forms.ComboBox();
            this.add_gift_idea = new System.Windows.Forms.Button();
            this.gift_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(109, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gift Name";
            // 
            // occasions
            // 
            this.occasions.FormattingEnabled = true;
            this.occasions.Location = new System.Drawing.Point(301, 344);
            this.occasions.Name = "occasions";
            this.occasions.Size = new System.Drawing.Size(304, 24);
            this.occasions.TabIndex = 2;
            // 
            // add_gift_idea
            // 
            this.add_gift_idea.BackColor = System.Drawing.Color.Crimson;
            this.add_gift_idea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_gift_idea.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_gift_idea.ForeColor = System.Drawing.Color.White;
            this.add_gift_idea.Location = new System.Drawing.Point(301, 457);
            this.add_gift_idea.Name = "add_gift_idea";
            this.add_gift_idea.Size = new System.Drawing.Size(304, 51);
            this.add_gift_idea.TabIndex = 3;
            this.add_gift_idea.Text = "Add Gift Idea";
            this.add_gift_idea.UseVisualStyleBackColor = false;
            this.add_gift_idea.Click += new System.EventHandler(this.add_gift_idea_Click);
            // 
            // gift_name
            // 
            this.gift_name.Location = new System.Drawing.Point(301, 291);
            this.gift_name.Name = "gift_name";
            this.gift_name.Size = new System.Drawing.Size(304, 22);
            this.gift_name.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(107, 218);
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
            this.label8.Location = new System.Drawing.Point(95, 77);
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
            this.label1.Location = new System.Drawing.Point(103, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Edit Recipient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(108, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Occasions";
            // 
            // AddGiftIdea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 641);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gift_name);
            this.Controls.Add(this.add_gift_idea);
            this.Controls.Add(this.occasions);
            this.Controls.Add(this.label2);
            this.Name = "AddGiftIdea";
            this.Text = "AddGiftIdea";
            this.Load += new System.EventHandler(this.AddGiftIdea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox occasions;
        private System.Windows.Forms.Button add_gift_idea;
        private System.Windows.Forms.TextBox gift_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}