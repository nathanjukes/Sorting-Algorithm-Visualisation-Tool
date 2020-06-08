namespace SortingAlgorithmVisualisation
{
    partial class DisplaySort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplaySort));
            this.algorithmPanel = new System.Windows.Forms.Panel();
            this.tComplexityLabel = new System.Windows.Forms.Label();
            this.sComplexityLabel = new System.Windows.Forms.Label();
            this.secondDelay = new System.Windows.Forms.Label();
            this.firstDelayConst = new System.Windows.Forms.Label();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.arraySettingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // algorithmPanel
            // 
            this.algorithmPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.algorithmPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.algorithmPanel.Location = new System.Drawing.Point(30, 70);
            this.algorithmPanel.Name = "algorithmPanel";
            this.algorithmPanel.Size = new System.Drawing.Size(1140, 521);
            this.algorithmPanel.TabIndex = 0;
            this.algorithmPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AlgorithmPanel_Paint);
            // 
            // tComplexityLabel
            // 
            this.tComplexityLabel.AutoSize = true;
            this.tComplexityLabel.BackColor = System.Drawing.Color.Transparent;
            this.tComplexityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.tComplexityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.tComplexityLabel.Location = new System.Drawing.Point(799, -4);
            this.tComplexityLabel.Name = "tComplexityLabel";
            this.tComplexityLabel.Size = new System.Drawing.Size(254, 40);
            this.tComplexityLabel.TabIndex = 2;
            this.tComplexityLabel.Text = "Time Complexity: ";
            // 
            // sComplexityLabel
            // 
            this.sComplexityLabel.AutoSize = true;
            this.sComplexityLabel.BackColor = System.Drawing.Color.Transparent;
            this.sComplexityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.sComplexityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.sComplexityLabel.Location = new System.Drawing.Point(799, 28);
            this.sComplexityLabel.Name = "sComplexityLabel";
            this.sComplexityLabel.Size = new System.Drawing.Size(266, 40);
            this.sComplexityLabel.TabIndex = 3;
            this.sComplexityLabel.Text = "Space Complexity: ";
            // 
            // secondDelay
            // 
            this.secondDelay.AutoSize = true;
            this.secondDelay.BackColor = System.Drawing.Color.Transparent;
            this.secondDelay.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.secondDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.secondDelay.Location = new System.Drawing.Point(-6, 28);
            this.secondDelay.Name = "secondDelay";
            this.secondDelay.Size = new System.Drawing.Size(225, 40);
            this.secondDelay.TabIndex = 4;
            this.secondDelay.Text = "Iteration Delay: ";
            // 
            // firstDelayConst
            // 
            this.firstDelayConst.AutoSize = true;
            this.firstDelayConst.BackColor = System.Drawing.Color.Transparent;
            this.firstDelayConst.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.firstDelayConst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.firstDelayConst.Location = new System.Drawing.Point(-6, -4);
            this.firstDelayConst.Name = "firstDelayConst";
            this.firstDelayConst.Size = new System.Drawing.Size(275, 40);
            this.firstDelayConst.TabIndex = 5;
            this.firstDelayConst.Text = "Initial Delay: 500ms";
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.AutoSize = true;
            this.algorithmLabel.BackColor = System.Drawing.Color.Transparent;
            this.algorithmLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.algorithmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.algorithmLabel.Location = new System.Drawing.Point(298, -4);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(165, 40);
            this.algorithmLabel.TabIndex = 6;
            this.algorithmLabel.Text = "Algorithm: ";
            // 
            // arraySettingLabel
            // 
            this.arraySettingLabel.AutoSize = true;
            this.arraySettingLabel.BackColor = System.Drawing.Color.Transparent;
            this.arraySettingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.arraySettingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.arraySettingLabel.Location = new System.Drawing.Point(298, 28);
            this.arraySettingLabel.Name = "arraySettingLabel";
            this.arraySettingLabel.Size = new System.Drawing.Size(204, 40);
            this.arraySettingLabel.TabIndex = 7;
            this.arraySettingLabel.Text = "Array Setting: ";
            // 
            // DisplaySort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1198, 605);
            this.Controls.Add(this.firstDelayConst);
            this.Controls.Add(this.secondDelay);
            this.Controls.Add(this.tComplexityLabel);
            this.Controls.Add(this.sComplexityLabel);
            this.Controls.Add(this.algorithmLabel);
            this.Controls.Add(this.arraySettingLabel);
            this.Controls.Add(this.algorithmPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplaySort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Sort";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplaySort_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel algorithmPanel;
        private System.Windows.Forms.Label tComplexityLabel;
        private System.Windows.Forms.Label sComplexityLabel;
        private System.Windows.Forms.Label secondDelay;
        private System.Windows.Forms.Label firstDelayConst;
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.Label arraySettingLabel;
    }
}