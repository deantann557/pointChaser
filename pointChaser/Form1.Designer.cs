namespace pointChaser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.P1PointLabel = new System.Windows.Forms.Label();
            this.P2PointLabel = new System.Windows.Forms.Label();
            this.VictoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // P1PointLabel
            // 
            this.P1PointLabel.Location = new System.Drawing.Point(162, 34);
            this.P1PointLabel.Name = "P1PointLabel";
            this.P1PointLabel.Size = new System.Drawing.Size(100, 23);
            this.P1PointLabel.TabIndex = 0;
            this.P1PointLabel.Text = "P1PointLabel";
            // 
            // P2PointLabel
            // 
            this.P2PointLabel.Location = new System.Drawing.Point(542, 34);
            this.P2PointLabel.Name = "P2PointLabel";
            this.P2PointLabel.Size = new System.Drawing.Size(100, 23);
            this.P2PointLabel.TabIndex = 1;
            this.P2PointLabel.Text = "P2PointLabel";
            // 
            // VictoryLabel
            // 
            this.VictoryLabel.Location = new System.Drawing.Point(327, 9);
            this.VictoryLabel.Name = "VictoryLabel";
            this.VictoryLabel.Size = new System.Drawing.Size(141, 58);
            this.VictoryLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.VictoryLabel);
            this.Controls.Add(this.P2PointLabel);
            this.Controls.Add(this.P1PointLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Point Chaser";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label P1PointLabel;
        private System.Windows.Forms.Label P2PointLabel;
        private System.Windows.Forms.Label VictoryLabel;
    }
}

