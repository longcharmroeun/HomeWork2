namespace HomeWork2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.GuessButton = new System.Windows.Forms.ToolStripButton();
            this.BarNum = new System.Windows.Forms.ToolStripProgressBar();
            this.ScoreText = new System.Windows.Forms.ToolStripLabel();
            this.Score = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBox,
            this.GuessButton,
            this.BarNum,
            this.ScoreText,
            this.Score});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TextBox
            // 
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 25);
            this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // GuessButton
            // 
            this.GuessButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GuessButton.Image = ((System.Drawing.Image)(resources.GetObject("GuessButton.Image")));
            this.GuessButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(42, 22);
            this.GuessButton.Text = "Guess";
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // BarNum
            // 
            this.BarNum.Name = "BarNum";
            this.BarNum.Size = new System.Drawing.Size(500, 22);
            // 
            // ScoreText
            // 
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(36, 22);
            this.ScoreText.Text = "Score";
            // 
            // Score
            // 
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(13, 22);
            this.Score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox TextBox;
        private System.Windows.Forms.ToolStripButton GuessButton;
        private System.Windows.Forms.ToolStripProgressBar BarNum;
        private System.Windows.Forms.ToolStripLabel Score;
        private System.Windows.Forms.ToolStripLabel ScoreText;
    }
}

