namespace GameOfLife
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.killNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.killPopulationButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.pattern1Button = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.spawnRaceComboBox = new System.Windows.Forms.ComboBox();
            this.spawnRaceLabel = new System.Windows.Forms.Label();
            this.racesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.racesLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.densityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.densityLabel = new System.Windows.Forms.Label();
            this.resolutionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pattern2Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.killNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pattern2Button);
            this.splitContainer1.Panel1.Controls.Add(this.killNumericUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.killPopulationButton);
            this.splitContainer1.Panel1.Controls.Add(this.generateButton);
            this.splitContainer1.Panel1.Controls.Add(this.pattern1Button);
            this.splitContainer1.Panel1.Controls.Add(this.clearButton);
            this.splitContainer1.Panel1.Controls.Add(this.resetButton);
            this.splitContainer1.Panel1.Controls.Add(this.spawnRaceComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.spawnRaceLabel);
            this.splitContainer1.Panel1.Controls.Add(this.racesNumericUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.racesLabel);
            this.splitContainer1.Panel1.Controls.Add(this.stopButton);
            this.splitContainer1.Panel1.Controls.Add(this.startButton);
            this.splitContainer1.Panel1.Controls.Add(this.densityNumericUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.densityLabel);
            this.splitContainer1.Panel1.Controls.Add(this.resolutionNumericUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.ResolutionLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 640);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 0;
            // 
            // killNumericUpDown
            // 
            this.killNumericUpDown.Enabled = false;
            this.killNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killNumericUpDown.Location = new System.Drawing.Point(16, 310);
            this.killNumericUpDown.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.killNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.killNumericUpDown.Name = "killNumericUpDown";
            this.killNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.killNumericUpDown.Size = new System.Drawing.Size(60, 22);
            this.killNumericUpDown.TabIndex = 17;
            this.killNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.killNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // killPopulationButton
            // 
            this.killPopulationButton.Enabled = false;
            this.killPopulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killPopulationButton.Location = new System.Drawing.Point(76, 305);
            this.killPopulationButton.Name = "killPopulationButton";
            this.killPopulationButton.Size = new System.Drawing.Size(60, 30);
            this.killPopulationButton.TabIndex = 16;
            this.killPopulationButton.Text = "Kill";
            this.killPopulationButton.UseVisualStyleBackColor = true;
            this.killPopulationButton.Click += new System.EventHandler(this.killPopulation_Click);
            // 
            // generateButton
            // 
            this.generateButton.Enabled = false;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(16, 264);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(120, 35);
            this.generateButton.TabIndex = 15;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // pattern1Button
            // 
            this.pattern1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pattern1Button.Location = new System.Drawing.Point(16, 423);
            this.pattern1Button.Name = "pattern1Button";
            this.pattern1Button.Size = new System.Drawing.Size(60, 35);
            this.pattern1Button.TabIndex = 14;
            this.pattern1Button.Text = "Ptrn 1";
            this.pattern1Button.UseVisualStyleBackColor = true;
            this.pattern1Button.Visible = false;
            this.pattern1Button.Click += new System.EventHandler(this.pattern1Button_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(16, 341);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 35);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(16, 382);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(120, 35);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // spawnRaceComboBox
            // 
            this.spawnRaceComboBox.Enabled = false;
            this.spawnRaceComboBox.FormattingEnabled = true;
            this.spawnRaceComboBox.Items.AddRange(new object[] {
            "Red",
            "Magenda",
            "Creamy"});
            this.spawnRaceComboBox.Location = new System.Drawing.Point(16, 179);
            this.spawnRaceComboBox.Name = "spawnRaceComboBox";
            this.spawnRaceComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spawnRaceComboBox.Size = new System.Drawing.Size(120, 21);
            this.spawnRaceComboBox.TabIndex = 11;
            this.spawnRaceComboBox.Text = "Color";
            this.spawnRaceComboBox.SelectedIndexChanged += new System.EventHandler(this.spawnRaceComboBox_SelectedIndexChanged);
            // 
            // spawnRaceLabel
            // 
            this.spawnRaceLabel.AutoSize = true;
            this.spawnRaceLabel.Location = new System.Drawing.Point(13, 163);
            this.spawnRaceLabel.Name = "spawnRaceLabel";
            this.spawnRaceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spawnRaceLabel.Size = new System.Drawing.Size(69, 13);
            this.spawnRaceLabel.TabIndex = 8;
            this.spawnRaceLabel.Text = "Spawn Race";
            // 
            // racesNumericUpDown
            // 
            this.racesNumericUpDown.Location = new System.Drawing.Point(16, 125);
            this.racesNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.racesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.racesNumericUpDown.Name = "racesNumericUpDown";
            this.racesNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.racesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.racesNumericUpDown.TabIndex = 7;
            this.racesNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.racesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // racesLabel
            // 
            this.racesLabel.AutoSize = true;
            this.racesLabel.Location = new System.Drawing.Point(13, 109);
            this.racesLabel.Name = "racesLabel";
            this.racesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.racesLabel.Size = new System.Drawing.Size(38, 13);
            this.racesLabel.TabIndex = 6;
            this.racesLabel.Text = "Races";
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(76, 223);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(60, 35);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(16, 223);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(60, 35);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // densityNumericUpDown
            // 
            this.densityNumericUpDown.Location = new System.Drawing.Point(16, 75);
            this.densityNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.densityNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.densityNumericUpDown.Name = "densityNumericUpDown";
            this.densityNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.densityNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.densityNumericUpDown.TabIndex = 3;
            this.densityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.densityNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Location = new System.Drawing.Point(13, 59);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.densityLabel.Size = new System.Drawing.Size(42, 13);
            this.densityLabel.TabIndex = 2;
            this.densityLabel.Text = "Density";
            // 
            // resolutionNumericUpDown
            // 
            this.resolutionNumericUpDown.Location = new System.Drawing.Point(16, 29);
            this.resolutionNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.resolutionNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.resolutionNumericUpDown.Name = "resolutionNumericUpDown";
            this.resolutionNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resolutionNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.resolutionNumericUpDown.TabIndex = 1;
            this.resolutionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resolutionNumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(13, 13);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResolutionLabel.Size = new System.Drawing.Size(57, 13);
            this.ResolutionLabel.TabIndex = 0;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 640);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pattern2Button
            // 
            this.pattern2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pattern2Button.Location = new System.Drawing.Point(76, 423);
            this.pattern2Button.Name = "pattern2Button";
            this.pattern2Button.Size = new System.Drawing.Size(60, 35);
            this.pattern2Button.TabIndex = 18;
            this.pattern2Button.Text = "Ptrn 2";
            this.pattern2Button.UseVisualStyleBackColor = true;
            this.pattern2Button.Visible = false;
            this.pattern2Button.Click += new System.EventHandler(this.pattern2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 640);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Game of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.killNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown resolutionNumericUpDown;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown densityNumericUpDown;
        private System.Windows.Forms.Label densityLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown racesNumericUpDown;
        private System.Windows.Forms.Label racesLabel;
        private System.Windows.Forms.Label spawnRaceLabel;
        private System.Windows.Forms.ComboBox spawnRaceComboBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button pattern1Button;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button killPopulationButton;
        private System.Windows.Forms.NumericUpDown killNumericUpDown;
        private System.Windows.Forms.Button pattern2Button;
    }
}

