
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.occasions = new System.Windows.Forms.ComboBox();
            this.add_gift_idea = new System.Windows.Forms.Button();
            this.gift_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Gift Idea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gift Name";
            // 
            // occasions
            // 
            this.occasions.FormattingEnabled = true;
            this.occasions.Location = new System.Drawing.Point(118, 120);
            this.occasions.Name = "occasions";
            this.occasions.Size = new System.Drawing.Size(121, 24);
            this.occasions.TabIndex = 2;
            // 
            // add_gift_idea
            // 
            this.add_gift_idea.Location = new System.Drawing.Point(118, 173);
            this.add_gift_idea.Name = "add_gift_idea";
            this.add_gift_idea.Size = new System.Drawing.Size(181, 59);
            this.add_gift_idea.TabIndex = 3;
            this.add_gift_idea.Text = "Add Gift Idea";
            this.add_gift_idea.UseVisualStyleBackColor = true;
            this.add_gift_idea.Click += new System.EventHandler(this.add_gift_idea_Click);
            // 
            // gift_name
            // 
            this.gift_name.Location = new System.Drawing.Point(212, 87);
            this.gift_name.Name = "gift_name";
            this.gift_name.Size = new System.Drawing.Size(212, 22);
            this.gift_name.TabIndex = 4;
            // 
            // AddGiftIdea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gift_name);
            this.Controls.Add(this.add_gift_idea);
            this.Controls.Add(this.occasions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddGiftIdea";
            this.Text = "AddGiftIdea";
            this.Load += new System.EventHandler(this.AddGiftIdea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox occasions;
        private System.Windows.Forms.Button add_gift_idea;
        private System.Windows.Forms.TextBox gift_name;
    }
}