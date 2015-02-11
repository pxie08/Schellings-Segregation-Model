namespace q526
{
    partial class q526
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
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toleranceTextbox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.tolLabel = new System.Windows.Forms.Label();
            this.gridheightTextbox = new System.Windows.Forms.TextBox();
            this.gridwidthTextbox = new System.Windows.Forms.TextBox();
            this.gridwidthLabel = new System.Windows.Forms.Label();
            this.gridheightLabel = new System.Windows.Forms.Label();
            this.perredTextbox = new System.Windows.Forms.TextBox();
            this.perblueTextbox = new System.Windows.Forms.TextBox();
            this.perBlue = new System.Windows.Forms.Label();
            this.perRed = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.terrainButton = new System.Windows.Forms.Button();
            this.terrainColorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(415, 292);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toleranceTextbox
            // 
            this.toleranceTextbox.Location = new System.Drawing.Point(444, 266);
            this.toleranceTextbox.Name = "toleranceTextbox";
            this.toleranceTextbox.Size = new System.Drawing.Size(46, 20);
            this.toleranceTextbox.TabIndex = 2;
            this.toleranceTextbox.Text = "4";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(415, 125);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // tolLabel
            // 
            this.tolLabel.AutoSize = true;
            this.tolLabel.Location = new System.Drawing.Point(380, 269);
            this.tolLabel.Name = "tolLabel";
            this.tolLabel.Size = new System.Drawing.Size(58, 13);
            this.tolLabel.TabIndex = 4;
            this.tolLabel.Text = "Tolerance:";
            // 
            // gridheightTextbox
            // 
            this.gridheightTextbox.Location = new System.Drawing.Point(444, 99);
            this.gridheightTextbox.Name = "gridheightTextbox";
            this.gridheightTextbox.Size = new System.Drawing.Size(46, 20);
            this.gridheightTextbox.TabIndex = 5;
            this.gridheightTextbox.Text = "20";
            // 
            // gridwidthTextbox
            // 
            this.gridwidthTextbox.Location = new System.Drawing.Point(444, 73);
            this.gridwidthTextbox.Name = "gridwidthTextbox";
            this.gridwidthTextbox.Size = new System.Drawing.Size(46, 20);
            this.gridwidthTextbox.TabIndex = 6;
            this.gridwidthTextbox.Text = "20";
            // 
            // gridwidthLabel
            // 
            this.gridwidthLabel.AutoSize = true;
            this.gridwidthLabel.Location = new System.Drawing.Point(378, 76);
            this.gridwidthLabel.Name = "gridwidthLabel";
            this.gridwidthLabel.Size = new System.Drawing.Size(60, 13);
            this.gridwidthLabel.TabIndex = 7;
            this.gridwidthLabel.Text = "Grid Width:";
            // 
            // gridheightLabel
            // 
            this.gridheightLabel.AutoSize = true;
            this.gridheightLabel.Location = new System.Drawing.Point(375, 102);
            this.gridheightLabel.Name = "gridheightLabel";
            this.gridheightLabel.Size = new System.Drawing.Size(63, 13);
            this.gridheightLabel.TabIndex = 8;
            this.gridheightLabel.Text = "Grid Height:";
            // 
            // perredTextbox
            // 
            this.perredTextbox.Location = new System.Drawing.Point(444, 38);
            this.perredTextbox.Name = "perredTextbox";
            this.perredTextbox.Size = new System.Drawing.Size(46, 20);
            this.perredTextbox.TabIndex = 9;
            this.perredTextbox.Text = "45";
            // 
            // perblueTextbox
            // 
            this.perblueTextbox.Location = new System.Drawing.Point(444, 12);
            this.perblueTextbox.Name = "perblueTextbox";
            this.perblueTextbox.Size = new System.Drawing.Size(46, 20);
            this.perblueTextbox.TabIndex = 10;
            this.perblueTextbox.Text = "45";
            // 
            // perBlue
            // 
            this.perBlue.AutoSize = true;
            this.perBlue.Location = new System.Drawing.Point(396, 15);
            this.perBlue.Name = "perBlue";
            this.perBlue.Size = new System.Drawing.Size(42, 13);
            this.perBlue.TabIndex = 11;
            this.perBlue.Text = "% Blue:";
            // 
            // perRed
            // 
            this.perRed.AutoSize = true;
            this.perRed.Location = new System.Drawing.Point(397, 41);
            this.perRed.Name = "perRed";
            this.perRed.Size = new System.Drawing.Size(41, 13);
            this.perRed.TabIndex = 12;
            this.perRed.Text = "% Red:";
            // 
            // terrainButton
            // 
            this.terrainButton.Location = new System.Drawing.Point(363, 198);
            this.terrainButton.Name = "terrainButton";
            this.terrainButton.Size = new System.Drawing.Size(75, 23);
            this.terrainButton.TabIndex = 15;
            this.terrainButton.Text = "Add Terrain";
            this.terrainButton.UseVisualStyleBackColor = true;
            this.terrainButton.Click += new System.EventHandler(this.terrainButton_Click);
            // 
            // terrainColorPanel
            // 
            this.terrainColorPanel.BackColor = System.Drawing.Color.Black;
            this.terrainColorPanel.Location = new System.Drawing.Point(444, 198);
            this.terrainColorPanel.Name = "terrainColorPanel";
            this.terrainColorPanel.Size = new System.Drawing.Size(46, 23);
            this.terrainColorPanel.TabIndex = 16;
            this.terrainColorPanel.Click += new System.EventHandler(this.terrainColorPanel_Click);
            // 
            // q526
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(502, 327);
            this.Controls.Add(this.terrainColorPanel);
            this.Controls.Add(this.terrainButton);
            this.Controls.Add(this.perRed);
            this.Controls.Add(this.perBlue);
            this.Controls.Add(this.perblueTextbox);
            this.Controls.Add(this.perredTextbox);
            this.Controls.Add(this.gridheightLabel);
            this.Controls.Add(this.gridwidthLabel);
            this.Controls.Add(this.gridwidthTextbox);
            this.Controls.Add(this.gridheightTextbox);
            this.Controls.Add(this.tolLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.toleranceTextbox);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "q526";
            this.Text = "Quest 526 -- Patrick Xie";
            this.Load += new System.EventHandler(this.q526_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        //private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.TextBox toleranceTextbox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label tolLabel;
        private System.Windows.Forms.TextBox gridheightTextbox;
        private System.Windows.Forms.TextBox gridwidthTextbox;
        private System.Windows.Forms.Label gridwidthLabel;
        private System.Windows.Forms.Label gridheightLabel;
        private System.Windows.Forms.TextBox perredTextbox;
        private System.Windows.Forms.TextBox perblueTextbox;
        private System.Windows.Forms.Label perBlue;
        private System.Windows.Forms.Label perRed;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button terrainButton;
        private System.Windows.Forms.Panel terrainColorPanel;
    }
}

