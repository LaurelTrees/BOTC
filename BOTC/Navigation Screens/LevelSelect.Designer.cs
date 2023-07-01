namespace BOTC
{
    partial class LevelSelect
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
            this.level1Button = new System.Windows.Forms.Button();
            this.level2Button = new System.Windows.Forms.Button();
            this.level3Button = new System.Windows.Forms.Button();
            this.level4Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // level1Button
            // 
            this.level1Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.level1Button.Location = new System.Drawing.Point(582, 629);
            this.level1Button.Name = "level1Button";
            this.level1Button.Size = new System.Drawing.Size(561, 213);
            this.level1Button.TabIndex = 0;
            this.level1Button.Text = "Level 1";
            this.level1Button.UseVisualStyleBackColor = true;
            this.level1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // level2Button
            // 
            this.level2Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.level2Button.Location = new System.Drawing.Point(1227, 629);
            this.level2Button.Name = "level2Button";
            this.level2Button.Size = new System.Drawing.Size(561, 213);
            this.level2Button.TabIndex = 1;
            this.level2Button.Text = "Level 2";
            this.level2Button.UseVisualStyleBackColor = true;
            this.level2Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // level3Button
            // 
            this.level3Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.level3Button.Location = new System.Drawing.Point(582, 915);
            this.level3Button.Name = "level3Button";
            this.level3Button.Size = new System.Drawing.Size(561, 213);
            this.level3Button.TabIndex = 2;
            this.level3Button.Text = "Level 3";
            this.level3Button.UseVisualStyleBackColor = true;
            this.level3Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // level4Button
            // 
            this.level4Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.level4Button.Location = new System.Drawing.Point(1227, 915);
            this.level4Button.Name = "level4Button";
            this.level4Button.Size = new System.Drawing.Size(561, 213);
            this.level4Button.TabIndex = 3;
            this.level4Button.Text = "Level 4";
            this.level4Button.UseVisualStyleBackColor = true;
            this.level4Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label1.Location = new System.Drawing.Point(578, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 107);
            this.label1.TabIndex = 4;
            this.label1.Text = "Level Select";
            // 
            // homeButton
            // 
            this.homeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeButton.Location = new System.Drawing.Point(1206, 417);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(346, 107);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Back to Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BOTC.Properties.Resources.soloLing;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1842, 1212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LevelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1842, 1212);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.level4Button);
            this.Controls.Add(this.level3Button);
            this.Controls.Add(this.level2Button);
            this.Controls.Add(this.level1Button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LevelSelect";
            this.Text = "LevelSelect";
            this.Load += new System.EventHandler(this.LevelSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button level1Button;
        private System.Windows.Forms.Button level2Button;
        private System.Windows.Forms.Button level3Button;
        private System.Windows.Forms.Button level4Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}