namespace BOTC
{
    partial class WinScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorBox = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(342, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 153);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stage Clear!";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.ErrorBox);
            this.panel1.Controls.Add(this.timeBox);
            this.panel1.Controls.Add(this.scoreBox);
            this.panel1.Controls.Add(this.continueButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.panel1.Location = new System.Drawing.Point(246, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 586);
            this.panel1.TabIndex = 1;
            // 
            // ErrorBox
            // 
            this.ErrorBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ErrorBox.AutoSize = true;
            this.ErrorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ErrorBox.Location = new System.Drawing.Point(74, 230);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(208, 46);
            this.ErrorBox.TabIndex = 4;
            this.ErrorBox.Text = "Lives lost: ";
            // 
            // timeBox
            // 
            this.timeBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeBox.AutoSize = true;
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeBox.Location = new System.Drawing.Point(74, 154);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(130, 46);
            this.timeBox.TabIndex = 3;
            this.timeBox.Text = "Time: ";
            // 
            // scoreBox
            // 
            this.scoreBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scoreBox.AutoSize = true;
            this.scoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.scoreBox.Location = new System.Drawing.Point(74, 309);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(148, 46);
            this.scoreBox.TabIndex = 2;
            this.scoreBox.Text = "Score: ";
            // 
            // continueButton
            // 
            this.continueButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.continueButton.Location = new System.Drawing.Point(440, 465);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(156, 69);
            this.continueButton.TabIndex = 1;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 63);
            this.label2.TabIndex = 0;
            this.label2.Text = "Level Stats:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BOTC.Properties.Resources.battleBackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1521, 1141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 1141);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WinScreen";
            this.Text = "WinScreen";
            this.Load += new System.EventHandler(this.WinScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label scoreBox;
        private System.Windows.Forms.Label timeBox;
        private System.Windows.Forms.Label ErrorBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}