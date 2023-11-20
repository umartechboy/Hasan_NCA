namespace VoicesFE01
{
    partial class ChannelControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Level = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.NumericUpDown();
            this.Gain = new System.Windows.Forms.NumericUpDown();
            this.Damping = new System.Windows.Forms.NumericUpDown();
            this.Title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.soundThreshold = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Damping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(0, 0);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(150, 29);
            this.Level.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Damping";
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(75, 38);
            this.Max.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(72, 27);
            this.Max.TabIndex = 3;
            this.Max.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // Gain
            // 
            this.Gain.Location = new System.Drawing.Point(75, 71);
            this.Gain.Name = "Gain";
            this.Gain.Size = new System.Drawing.Size(72, 27);
            this.Gain.TabIndex = 3;
            this.Gain.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Damping
            // 
            this.Damping.Location = new System.Drawing.Point(75, 102);
            this.Damping.Name = "Damping";
            this.Damping.Size = new System.Drawing.Size(72, 27);
            this.Damping.TabIndex = 3;
            this.Damping.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(0, 182);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(144, 41);
            this.Title.TabIndex = 4;
            this.Title.Text = "A0";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Th %";
            // 
            // soundThreshold
            // 
            this.soundThreshold.Location = new System.Drawing.Point(75, 135);
            this.soundThreshold.Name = "soundThreshold";
            this.soundThreshold.Size = new System.Drawing.Size(72, 27);
            this.soundThreshold.TabIndex = 3;
            this.soundThreshold.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // ChannelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.soundThreshold);
            this.Controls.Add(this.Damping);
            this.Controls.Add(this.Gain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Level);
            this.Name = "ChannelControl";
            this.Size = new System.Drawing.Size(150, 239);
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Damping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        public ProgressBar Level;
        public NumericUpDown Max;
        public NumericUpDown Gain;
        public NumericUpDown Damping;
        public Label Title;
        private Label label4;
        public NumericUpDown soundThreshold;
    }
}
