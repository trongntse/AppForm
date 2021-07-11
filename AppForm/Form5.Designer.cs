
namespace AppForm
{
    partial class Form5
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
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.panelColor = new System.Windows.Forms.Panel();
            this.lblCurrColor = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(152, 196);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(419, 45);
            this.redTrackBar.TabIndex = 0;
            this.redTrackBar.TickFrequency = 5;
            this.redTrackBar.Scroll += new System.EventHandler(this.red_scroll_event);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blue:";
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(152, 256);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(419, 45);
            this.greenTrackBar.TabIndex = 4;
            this.greenTrackBar.TickFrequency = 5;
            this.greenTrackBar.Scroll += new System.EventHandler(this.green_scroll_event);
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Location = new System.Drawing.Point(152, 325);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(419, 45);
            this.blueTrackBar.TabIndex = 5;
            this.blueTrackBar.TickFrequency = 5;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blue_scroll_event);
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.lblCurrColor);
            this.panelColor.Location = new System.Drawing.Point(91, 12);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(535, 158);
            this.panelColor.TabIndex = 6;
            // 
            // lblCurrColor
            // 
            this.lblCurrColor.Location = new System.Drawing.Point(82, 36);
            this.lblCurrColor.Name = "lblCurrColor";
            this.lblCurrColor.Size = new System.Drawing.Size(319, 100);
            this.lblCurrColor.TabIndex = 0;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redTrackBar);
            this.Name = "Form5";
            this.RightToLeftLayout = true;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.FlowLayoutPanel lblCurrColor;
    }
}