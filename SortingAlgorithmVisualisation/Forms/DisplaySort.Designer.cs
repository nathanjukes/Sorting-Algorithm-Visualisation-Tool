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
            this.algorithmPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // algorithmPanel
            // 
            this.algorithmPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.algorithmPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.algorithmPanel.Location = new System.Drawing.Point(23, 12);
            this.algorithmPanel.Name = "algorithmPanel";
            this.algorithmPanel.Size = new System.Drawing.Size(1140, 521);
            this.algorithmPanel.TabIndex = 0;
            this.algorithmPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.algorithmPanel_Paint);
            // 
            // DisplaySort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 545);
            this.Controls.Add(this.algorithmPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplaySort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Sort";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel algorithmPanel;
    }
}