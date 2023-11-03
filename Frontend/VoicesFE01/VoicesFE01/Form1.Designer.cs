namespace VoicesFE01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.N1B = new System.Windows.Forms.Button();
            this.N2B = new System.Windows.Forms.Button();
            this.openPortB = new System.Windows.Forms.Button();
            this.portsCB = new System.Windows.Forms.ComboBox();
            this.findPortsB = new System.Windows.Forms.Button();
            this.piezo1PB = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // N1B
            // 
            this.N1B.Location = new System.Drawing.Point(12, 12);
            this.N1B.Name = "N1B";
            this.N1B.Size = new System.Drawing.Size(94, 29);
            this.N1B.TabIndex = 0;
            this.N1B.Text = "1";
            this.N1B.UseVisualStyleBackColor = true;
            this.N1B.Click += new System.EventHandler(this.N1B_Click);
            // 
            // N2B
            // 
            this.N2B.Location = new System.Drawing.Point(112, 12);
            this.N2B.Name = "N2B";
            this.N2B.Size = new System.Drawing.Size(94, 29);
            this.N2B.TabIndex = 0;
            this.N2B.Text = "2";
            this.N2B.UseVisualStyleBackColor = true;
            this.N2B.Click += new System.EventHandler(this.N2B_Click);
            // 
            // openPortB
            // 
            this.openPortB.Location = new System.Drawing.Point(12, 123);
            this.openPortB.Name = "openPortB";
            this.openPortB.Size = new System.Drawing.Size(94, 29);
            this.openPortB.TabIndex = 1;
            this.openPortB.Text = "Open";
            this.openPortB.UseVisualStyleBackColor = true;
            this.openPortB.Click += new System.EventHandler(this.openPortB_Click);
            // 
            // portsCB
            // 
            this.portsCB.FormattingEnabled = true;
            this.portsCB.Location = new System.Drawing.Point(112, 124);
            this.portsCB.Name = "portsCB";
            this.portsCB.Size = new System.Drawing.Size(151, 28);
            this.portsCB.TabIndex = 2;
            // 
            // findPortsB
            // 
            this.findPortsB.Location = new System.Drawing.Point(269, 123);
            this.findPortsB.Name = "findPortsB";
            this.findPortsB.Size = new System.Drawing.Size(94, 29);
            this.findPortsB.TabIndex = 1;
            this.findPortsB.Text = "--";
            this.findPortsB.UseVisualStyleBackColor = true;
            this.findPortsB.Click += new System.EventHandler(this.findPortsB_Click);
            // 
            // piezo1PB
            // 
            this.piezo1PB.Location = new System.Drawing.Point(12, 47);
            this.piezo1PB.Maximum = 10000;
            this.piezo1PB.Name = "piezo1PB";
            this.piezo1PB.Size = new System.Drawing.Size(94, 29);
            this.piezo1PB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 166);
            this.Controls.Add(this.piezo1PB);
            this.Controls.Add(this.portsCB);
            this.Controls.Add(this.findPortsB);
            this.Controls.Add(this.openPortB);
            this.Controls.Add(this.N2B);
            this.Controls.Add(this.N1B);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button N1B;
        private Button N2B;
        private Button openPortB;
        private ComboBox portsCB;
        private Button findPortsB;
        private ProgressBar piezo1PB;
    }
}