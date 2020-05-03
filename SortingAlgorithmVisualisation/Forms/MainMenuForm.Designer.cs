namespace SortingAlgorithmVisualisation
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.sizeTrackBar = new System.Windows.Forms.TrackBar();
            this.originalTimeBox = new System.Windows.Forms.CheckBox();
            this.selectedAlgorithmLabel = new System.Windows.Forms.Label();
            this.AlgorithmGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.BackgroundDrawWorker = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            this.AlgorithmGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(594, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 117);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sort!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AccessibleName = "Bubble Sort";
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(143, 28);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bubble Sort";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AccessibleName = "Merge Sort";
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(6, 110);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(138, 28);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Merge Sort";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AccessibleName = "Insertion Sort";
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(6, 160);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(154, 28);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Insertion Sort";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AccessibleName = "Quick Sort";
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(6, 264);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(130, 28);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "Quick Sort";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AccessibleName = "Heap Sort";
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(6, 210);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(127, 28);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "Heap Sort";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AccessibleName = "Bogo Sort";
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(6, 260);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(125, 28);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.Text = "Bogo Sort";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AccessibleName = "Selection Sort";
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(6, 360);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(165, 28);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.Text = "Selection Sort";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AccessibleName = "Radix Sort";
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(6, 410);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(125, 28);
            this.radioButton9.TabIndex = 9;
            this.radioButton9.Text = "Radix Sort";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AccessibleName = "Cocktail Sort";
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.Location = new System.Drawing.Point(6, 310);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(156, 28);
            this.radioButton10.TabIndex = 10;
            this.radioButton10.Text = "Cocktail Sort";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // sizeTrackBar
            // 
            this.sizeTrackBar.LargeChange = 1;
            this.sizeTrackBar.Location = new System.Drawing.Point(372, 226);
            this.sizeTrackBar.Maximum = 5;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Size = new System.Drawing.Size(181, 45);
            this.sizeTrackBar.TabIndex = 12;
            this.sizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sizeTrackBar.Value = 1;
            // 
            // originalTimeBox
            // 
            this.originalTimeBox.AutoSize = true;
            this.originalTimeBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalTimeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.originalTimeBox.Location = new System.Drawing.Point(380, 276);
            this.originalTimeBox.Name = "originalTimeBox";
            this.originalTimeBox.Size = new System.Drawing.Size(181, 29);
            this.originalTimeBox.TabIndex = 13;
            this.originalTimeBox.Text = "Sort in Real Time ";
            this.originalTimeBox.UseVisualStyleBackColor = true;
            // 
            // selectedAlgorithmLabel
            // 
            this.selectedAlgorithmLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.selectedAlgorithmLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedAlgorithmLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedAlgorithmLabel.Location = new System.Drawing.Point(18, 457);
            this.selectedAlgorithmLabel.Name = "selectedAlgorithmLabel";
            this.selectedAlgorithmLabel.Size = new System.Drawing.Size(309, 36);
            this.selectedAlgorithmLabel.TabIndex = 14;
            this.selectedAlgorithmLabel.Text = "Bubble Sort Selected";
            this.selectedAlgorithmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlgorithmGroupBox
            // 
            this.AlgorithmGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.AlgorithmGroupBox.Controls.Add(this.radioButton11);
            this.AlgorithmGroupBox.Controls.Add(this.panel1);
            this.AlgorithmGroupBox.Controls.Add(this.radioButton2);
            this.AlgorithmGroupBox.Controls.Add(this.radioButton1);
            this.AlgorithmGroupBox.Controls.Add(this.radioButton3);
            this.AlgorithmGroupBox.Controls.Add(this.radioButton5);
            this.AlgorithmGroupBox.Controls.Add(this.radioButton9);
            this.AlgorithmGroupBox.Controls.Add(this.radioButton10);
            this.AlgorithmGroupBox.Controls.Add(this.radioButton6);
            this.AlgorithmGroupBox.Controls.Add(this.radioButton7);
            this.AlgorithmGroupBox.Controls.Add(this.radioButton4);
            this.AlgorithmGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlgorithmGroupBox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgorithmGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AlgorithmGroupBox.Name = "AlgorithmGroupBox";
            this.AlgorithmGroupBox.Size = new System.Drawing.Size(321, 464);
            this.AlgorithmGroupBox.TabIndex = 15;
            this.AlgorithmGroupBox.TabStop = false;
            this.AlgorithmGroupBox.Text = "Algorithms ";
            // 
            // radioButton11
            // 
            this.radioButton11.AccessibleName = "Quick Sort";
            this.radioButton11.AutoSize = true;
            this.radioButton11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton11.Location = new System.Drawing.Point(185, 60);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(130, 28);
            this.radioButton11.TabIndex = 18;
            this.radioButton11.Text = "Quick Sort";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(5, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 18);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(17, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 25);
            this.panel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(375, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(353, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(497, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "View full project at:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.githubLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.githubLinkLabel.Location = new System.Drawing.Point(376, 489);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(480, 21);
            this.githubLinkLabel.TabIndex = 21;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "https://github.com/nathanjukes/Sorting-Algorithm-Visualisation";
            this.githubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.label2.Location = new System.Drawing.Point(359, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 73);
            this.label2.TabIndex = 22;
            this.label2.Text = "Please Note: Within the \'Bogo Sort\', the light blue colouring is used for display" +
    "ing the original set of elements before the new sort is shown.\r\n\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(862, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedAlgorithmLabel);
            this.Controls.Add(this.AlgorithmGroupBox);
            this.Controls.Add(this.originalTimeBox);
            this.Controls.Add(this.sizeTrackBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.githubLinkLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            this.AlgorithmGroupBox.ResumeLayout(false);
            this.AlgorithmGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.TrackBar sizeTrackBar;
        private System.Windows.Forms.CheckBox originalTimeBox;
        private System.Windows.Forms.Label selectedAlgorithmLabel;
        private System.Windows.Forms.GroupBox AlgorithmGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.ComponentModel.BackgroundWorker BackgroundDrawWorker;
        private System.Windows.Forms.Label label2;
    }
}

