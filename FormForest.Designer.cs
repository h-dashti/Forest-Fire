namespace ForestLife
{
    partial class FormForest
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
            this.textBoxProbability = new System.Windows.Forms.TextBox();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelProbabilty = new System.Windows.Forms.Label();
            this.labelStep = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxStructure = new System.Windows.Forms.GroupBox();
            this.textBox_H = new System.Windows.Forms.TextBox();
            this.textBox_L = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownIt = new System.Windows.Forms.NumericUpDown();
            this.buttonAutomatic = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar_Latency = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.randomDistributionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDistributionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_nFired = new System.Windows.Forms.Label();
            this.label_nGreen = new System.Windows.Forms.Label();
            this.groupBoxBoundary = new System.Windows.Forms.GroupBox();
            this.checkBoxCycleY = new System.Windows.Forms.CheckBox();
            this.checkBoxCycleX = new System.Windows.Forms.CheckBox();
            this.buttonSnapshot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxStructure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Latency)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxBoundary.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxProbability
            // 
            this.textBoxProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProbability.ForeColor = System.Drawing.Color.Black;
            this.textBoxProbability.Location = new System.Drawing.Point(276, 29);
            this.textBoxProbability.Name = "textBoxProbability";
            this.textBoxProbability.Size = new System.Drawing.Size(75, 20);
            this.textBoxProbability.TabIndex = 10;
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Location = new System.Drawing.Point(96, 58);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(64, 24);
            this.buttonNextStep.TabIndex = 8;
            this.buttonNextStep.Text = "Next Step";
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(23, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 501);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // labelProbabilty
            // 
            this.labelProbabilty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProbabilty.ForeColor = System.Drawing.Color.Blue;
            this.labelProbabilty.Location = new System.Drawing.Point(20, 32);
            this.labelProbabilty.Name = "labelProbabilty";
            this.labelProbabilty.Size = new System.Drawing.Size(265, 21);
            this.labelProbabilty.TabIndex = 11;
            this.labelProbabilty.Text = "Probability that an empty Sapce to be Green ";
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Location = new System.Drawing.Point(256, 90);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(59, 13);
            this.labelStep.TabIndex = 12;
            this.labelStep.Text = "lalabelStep";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(185, 58);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(64, 24);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Reset";
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBoxStructure
            // 
            this.groupBoxStructure.Controls.Add(this.textBox_H);
            this.groupBoxStructure.Controls.Add(this.textBox_L);
            this.groupBoxStructure.Controls.Add(this.label3);
            this.groupBoxStructure.Controls.Add(this.label2);
            this.groupBoxStructure.Location = new System.Drawing.Point(530, 108);
            this.groupBoxStructure.Name = "groupBoxStructure";
            this.groupBoxStructure.Size = new System.Drawing.Size(129, 109);
            this.groupBoxStructure.TabIndex = 27;
            this.groupBoxStructure.TabStop = false;
            this.groupBoxStructure.Text = "Structure";
            // 
            // textBox_H
            // 
            this.textBox_H.Location = new System.Drawing.Point(56, 84);
            this.textBox_H.Name = "textBox_H";
            this.textBox_H.Size = new System.Drawing.Size(55, 20);
            this.textBox_H.TabIndex = 28;
            // 
            // textBox_L
            // 
            this.textBox_L.Location = new System.Drawing.Point(56, 40);
            this.textBox_L.Name = "textBox_L";
            this.textBox_L.Size = new System.Drawing.Size(55, 20);
            this.textBox_L.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "H (Height of Lattice)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "L (Width of Lattice)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(594, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "steps";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Take a sample every";
            // 
            // numericUpDownIt
            // 
            this.numericUpDownIt.Location = new System.Drawing.Point(524, 30);
            this.numericUpDownIt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownIt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIt.Name = "numericUpDownIt";
            this.numericUpDownIt.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownIt.TabIndex = 28;
            this.numericUpDownIt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAutomatic
            // 
            this.buttonAutomatic.Location = new System.Drawing.Point(23, 59);
            this.buttonAutomatic.Name = "buttonAutomatic";
            this.buttonAutomatic.Size = new System.Drawing.Size(67, 23);
            this.buttonAutomatic.TabIndex = 31;
            this.buttonAutomatic.Text = "Automatic";
            this.buttonAutomatic.UseVisualStyleBackColor = true;
            this.buttonAutomatic.Click += new System.EventHandler(this.buttonAutomatic_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar_Latency
            // 
            this.trackBar_Latency.Location = new System.Drawing.Point(529, 295);
            this.trackBar_Latency.Name = "trackBar_Latency";
            this.trackBar_Latency.Size = new System.Drawing.Size(126, 45);
            this.trackBar_Latency.TabIndex = 32;
            this.trackBar_Latency.Value = 9;
            this.trackBar_Latency.Scroll += new System.EventHandler(this.trackBar_Latency_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomDistributionToolStripMenuItem,
            this.manualDistributionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // randomDistributionToolStripMenuItem
            // 
            this.randomDistributionToolStripMenuItem.Name = "randomDistributionToolStripMenuItem";
            this.randomDistributionToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.randomDistributionToolStripMenuItem.Text = "&Random Distribution";
            this.randomDistributionToolStripMenuItem.Click += new System.EventHandler(this.menuItemRandom_Click);
            // 
            // manualDistributionToolStripMenuItem
            // 
            this.manualDistributionToolStripMenuItem.Name = "manualDistributionToolStripMenuItem";
            this.manualDistributionToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.manualDistributionToolStripMenuItem.Text = "&Manual Distribution";
            this.manualDistributionToolStripMenuItem.Click += new System.EventHandler(this.menuItemManualDistribution_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label_nFired
            // 
            this.label_nFired.AutoSize = true;
            this.label_nFired.Location = new System.Drawing.Point(351, 90);
            this.label_nFired.Name = "label_nFired";
            this.label_nFired.Size = new System.Drawing.Size(52, 13);
            this.label_nFired.TabIndex = 34;
            this.label_nFired.Text = "labelFired";
            // 
            // label_nGreen
            // 
            this.label_nGreen.AutoSize = true;
            this.label_nGreen.Location = new System.Drawing.Point(454, 90);
            this.label_nGreen.Name = "label_nGreen";
            this.label_nGreen.Size = new System.Drawing.Size(58, 13);
            this.label_nGreen.TabIndex = 35;
            this.label_nGreen.Text = "labelGreen";
            // 
            // groupBoxBoundary
            // 
            this.groupBoxBoundary.Controls.Add(this.checkBoxCycleY);
            this.groupBoxBoundary.Controls.Add(this.checkBoxCycleX);
            this.groupBoxBoundary.Location = new System.Drawing.Point(530, 225);
            this.groupBoxBoundary.Name = "groupBoxBoundary";
            this.groupBoxBoundary.Size = new System.Drawing.Size(129, 65);
            this.groupBoxBoundary.TabIndex = 36;
            this.groupBoxBoundary.TabStop = false;
            this.groupBoxBoundary.Text = "Boundary";
            // 
            // checkBoxCycleY
            // 
            this.checkBoxCycleY.AutoSize = true;
            this.checkBoxCycleY.Location = new System.Drawing.Point(9, 37);
            this.checkBoxCycleY.Name = "checkBoxCycleY";
            this.checkBoxCycleY.Size = new System.Drawing.Size(104, 17);
            this.checkBoxCycleY.TabIndex = 1;
            this.checkBoxCycleY.Text = "cyclic y direction";
            this.checkBoxCycleY.UseVisualStyleBackColor = true;
            this.checkBoxCycleY.Click += new System.EventHandler(this.checkBoxCycleX_Click);
            // 
            // checkBoxCycleX
            // 
            this.checkBoxCycleX.AutoSize = true;
            this.checkBoxCycleX.Location = new System.Drawing.Point(9, 19);
            this.checkBoxCycleX.Name = "checkBoxCycleX";
            this.checkBoxCycleX.Size = new System.Drawing.Size(104, 17);
            this.checkBoxCycleX.TabIndex = 0;
            this.checkBoxCycleX.Text = "cyclic x direction";
            this.checkBoxCycleX.UseVisualStyleBackColor = true;
            this.checkBoxCycleX.Click += new System.EventHandler(this.checkBoxCycleX_Click);
            // 
            // buttonSnapshot
            // 
            this.buttonSnapshot.Location = new System.Drawing.Point(276, 58);
            this.buttonSnapshot.Name = "buttonSnapshot";
            this.buttonSnapshot.Size = new System.Drawing.Size(75, 23);
            this.buttonSnapshot.TabIndex = 37;
            this.buttonSnapshot.Text = "Snapshot";
            this.buttonSnapshot.UseVisualStyleBackColor = true;
            this.buttonSnapshot.Click += new System.EventHandler(this.buttonSnapshot_Click);
            // 
            // FormForest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(775, 595);
            this.Controls.Add(this.buttonSnapshot);
            this.Controls.Add(this.groupBoxBoundary);
            this.Controls.Add(this.label_nGreen);
            this.Controls.Add(this.label_nFired);
            this.Controls.Add(this.trackBar_Latency);
            this.Controls.Add(this.buttonAutomatic);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownIt);
            this.Controls.Add(this.groupBoxStructure);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.textBoxProbability);
            this.Controls.Add(this.buttonNextStep);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelProbabilty);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormForest";
            this.Text = "Forest Life";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormForest_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxStructure.ResumeLayout(false);
            this.groupBoxStructure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Latency)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxBoundary.ResumeLayout(false);
            this.groupBoxBoundary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProbability;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelProbabilty;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBoxStructure;
        private System.Windows.Forms.TextBox textBox_H;
        private System.Windows.Forms.TextBox textBox_L;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownIt;
        private System.Windows.Forms.Button buttonAutomatic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar_Latency;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randomDistributionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDistributionToolStripMenuItem;
        private System.Windows.Forms.Label label_nFired;
        private System.Windows.Forms.Label label_nGreen;
        private System.Windows.Forms.GroupBox groupBoxBoundary;
        private System.Windows.Forms.CheckBox checkBoxCycleX;
        private System.Windows.Forms.CheckBox checkBoxCycleY;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonSnapshot;
    }
}

