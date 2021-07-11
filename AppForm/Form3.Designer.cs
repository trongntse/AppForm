
namespace AppForm
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.myCalendar = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myToolTip
            // 
            this.myToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // myCalendar
            // 
            this.myCalendar.Location = new System.Drawing.Point(241, 66);
            this.myCalendar.Name = "myCalendar";
            this.myCalendar.TabIndex = 0;
            this.myToolTip.SetToolTip(this.myCalendar, "select your day");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Select Day";
            this.myToolTip.SetToolTip(this.button1, "Click to view your day");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myCalendar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.MonthCalendar myCalendar;
        private System.Windows.Forms.Button button1;
    }
}