
namespace AppForm
{
    partial class Form1
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMultiline = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaske = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password TextBox:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(198, 31);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(419, 22);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Multiline TextBox:";
            // 
            // txtMultiline
            // 
            this.txtMultiline.Location = new System.Drawing.Point(198, 80);
            this.txtMultiline.Name = "txtMultiline";
            this.txtMultiline.Size = new System.Drawing.Size(419, 96);
            this.txtMultiline.TabIndex = 3;
            this.txtMultiline.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Uppercase Only:";
            // 
            // txtUpper
            // 
            this.txtUpper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUpper.Location = new System.Drawing.Point(198, 220);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(419, 22);
            this.txtUpper.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maked TextBox";
            // 
            // txtMaske
            // 
            this.txtMaske.Location = new System.Drawing.Point(198, 328);
            this.txtMaske.Mask = "(999)000-0000";
            this.txtMaske.Name = "txtMaske";
            this.txtMaske.Size = new System.Drawing.Size(419, 22);
            this.txtMaske.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Display Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMaske);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUpper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMultiline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMultiline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtMaske;
        private System.Windows.Forms.Button button1;
    }
}

