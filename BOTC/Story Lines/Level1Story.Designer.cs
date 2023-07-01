namespace BOTC
{
    partial class Level1Story
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.dialogueBox = new System.Windows.Forms.Label();
            this.lingName = new System.Windows.Forms.Label();
            this.characterName = new System.Windows.Forms.Label();
            this.soloLing = new System.Windows.Forms.PictureBox();
            this.lingLeena = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soloLing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lingLeena)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.buttonContinue);
            this.panel1.Controls.Add(this.dialogueBox);
            this.panel1.Location = new System.Drawing.Point(278, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 355);
            this.panel1.TabIndex = 1;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonContinue.Location = new System.Drawing.Point(571, 223);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(250, 90);
            this.buttonContinue.TabIndex = 1;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // dialogueBox
            // 
            this.dialogueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogueBox.AutoSize = true;
            this.dialogueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dialogueBox.Location = new System.Drawing.Point(60, 62);
            this.dialogueBox.Name = "dialogueBox";
            this.dialogueBox.Size = new System.Drawing.Size(72, 63);
            this.dialogueBox.TabIndex = 0;
            this.dialogueBox.Text = "...";
            // 
            // lingName
            // 
            this.lingName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lingName.AutoSize = true;
            this.lingName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lingName.Location = new System.Drawing.Point(319, 372);
            this.lingName.Name = "lingName";
            this.lingName.Size = new System.Drawing.Size(130, 63);
            this.lingName.TabIndex = 0;
            this.lingName.Text = "Ling";
            // 
            // characterName
            // 
            this.characterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.characterName.AutoSize = true;
            this.characterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.characterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.characterName.Location = new System.Drawing.Point(966, 370);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(117, 63);
            this.characterName.TabIndex = 2;
            this.characterName.Text = "???";
            // 
            // soloLing
            // 
            this.soloLing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soloLing.Image = global::BOTC.Properties.Resources.soloLing;
            this.soloLing.Location = new System.Drawing.Point(0, 0);
            this.soloLing.Name = "soloLing";
            this.soloLing.Size = new System.Drawing.Size(1482, 848);
            this.soloLing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soloLing.TabIndex = 0;
            this.soloLing.TabStop = false;
            // 
            // lingLeena
            // 
            this.lingLeena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lingLeena.Image = global::BOTC.Properties.Resources.lingLeena;
            this.lingLeena.Location = new System.Drawing.Point(0, 0);
            this.lingLeena.Name = "lingLeena";
            this.lingLeena.Size = new System.Drawing.Size(1482, 848);
            this.lingLeena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lingLeena.TabIndex = 3;
            this.lingLeena.TabStop = false;
            // 
            // Level1Story
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 848);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.lingName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.soloLing);
            this.Controls.Add(this.lingLeena);
            this.Name = "Level1Story";
            this.Text = "Level1Story";
            this.Load += new System.EventHandler(this.Level1Story_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soloLing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lingLeena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox soloLing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lingName;
        private System.Windows.Forms.Label dialogueBox;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label characterName;
        private System.Windows.Forms.PictureBox lingLeena;
    }
}