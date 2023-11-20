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
            this.openPortB = new System.Windows.Forms.Button();
            this.portsCB = new System.Windows.Forms.ComboBox();
            this.findPortsB = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addChannelsB = new System.Windows.Forms.Button();
            this.removeChannelsB = new System.Windows.Forms.Button();
            this.repeatDurationNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repeatDurationNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // openPortB
            // 
            this.openPortB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openPortB.Location = new System.Drawing.Point(12, 355);
            this.openPortB.Name = "openPortB";
            this.openPortB.Size = new System.Drawing.Size(94, 29);
            this.openPortB.TabIndex = 1;
            this.openPortB.Text = "Open";
            this.openPortB.UseVisualStyleBackColor = true;
            this.openPortB.Click += new System.EventHandler(this.openPortB_Click);
            // 
            // portsCB
            // 
            this.portsCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.portsCB.FormattingEnabled = true;
            this.portsCB.Location = new System.Drawing.Point(112, 356);
            this.portsCB.Name = "portsCB";
            this.portsCB.Size = new System.Drawing.Size(151, 28);
            this.portsCB.TabIndex = 2;
            // 
            // findPortsB
            // 
            this.findPortsB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.findPortsB.Location = new System.Drawing.Point(269, 355);
            this.findPortsB.Name = "findPortsB";
            this.findPortsB.Size = new System.Drawing.Size(94, 29);
            this.findPortsB.TabIndex = 1;
            this.findPortsB.Text = "--";
            this.findPortsB.UseVisualStyleBackColor = true;
            this.findPortsB.Click += new System.EventHandler(this.findPortsB_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(538, 304);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // addChannelsB
            // 
            this.addChannelsB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addChannelsB.Location = new System.Drawing.Point(520, 322);
            this.addChannelsB.Name = "addChannelsB";
            this.addChannelsB.Size = new System.Drawing.Size(30, 29);
            this.addChannelsB.TabIndex = 0;
            this.addChannelsB.Text = "+";
            this.addChannelsB.UseVisualStyleBackColor = true;
            this.addChannelsB.Click += new System.EventHandler(this.addChannelsB_Click);
            // 
            // removeChannelsB
            // 
            this.removeChannelsB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeChannelsB.Location = new System.Drawing.Point(484, 322);
            this.removeChannelsB.Name = "removeChannelsB";
            this.removeChannelsB.Size = new System.Drawing.Size(30, 29);
            this.removeChannelsB.TabIndex = 0;
            this.removeChannelsB.Text = "-";
            this.removeChannelsB.UseVisualStyleBackColor = true;
            this.removeChannelsB.Click += new System.EventHandler(this.removeChannelsB_Click);
            // 
            // repeatDurationNUD
            // 
            this.repeatDurationNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.repeatDurationNUD.Location = new System.Drawing.Point(194, 323);
            this.repeatDurationNUD.Maximum = 10000;
            this.repeatDurationNUD.Name = "repeatDurationNUD";
            this.repeatDurationNUD.Size = new System.Drawing.Size(69, 27);
            this.repeatDurationNUD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Don\'t repeat before (ms)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repeatDurationNUD);
            this.Controls.Add(this.removeChannelsB);
            this.Controls.Add(this.addChannelsB);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.portsCB);
            this.Controls.Add(this.findPortsB);
            this.Controls.Add(this.openPortB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.repeatDurationNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button openPortB;
        private ComboBox portsCB;
        private Button findPortsB;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button addChannelsB;
        private Button removeChannelsB;
        private NumericUpDown repeatDurationNUD;
        private Label label1;
    }
}