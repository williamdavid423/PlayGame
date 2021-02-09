namespace PlayGame
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
            this.PlayGameButton = new System.Windows.Forms.Button();
            this.GameStartLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayGameButton
            // 
            this.PlayGameButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayGameButton.Font = new System.Drawing.Font("Amelia BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGameButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayGameButton.ImageKey = "(none)";
            this.PlayGameButton.Location = new System.Drawing.Point(90, 65);
            this.PlayGameButton.Name = "PlayGameButton";
            this.PlayGameButton.Size = new System.Drawing.Size(215, 88);
            this.PlayGameButton.TabIndex = 0;
            this.PlayGameButton.Text = "Play Game";
            this.PlayGameButton.UseVisualStyleBackColor = false;
            this.PlayGameButton.Click += new System.EventHandler(this.PlayGameButton_Click);
            // 
            // GameStartLabel1
            // 
            this.GameStartLabel1.Font = new System.Drawing.Font("Amelia BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStartLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameStartLabel1.Location = new System.Drawing.Point(109, 331);
            this.GameStartLabel1.Name = "GameStartLabel1";
            this.GameStartLabel1.Size = new System.Drawing.Size(172, 35);
            this.GameStartLabel1.TabIndex = 1;
            this.GameStartLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameStartLabel1.Click += new System.EventHandler(this.GameStartLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.GameStartLabel1);
            this.Controls.Add(this.PlayGameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayGameButton;
        private System.Windows.Forms.Label GameStartLabel1;
    }
}

