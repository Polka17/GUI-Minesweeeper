
namespace Minesweeper
{
    partial class Difficulty
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseLabel = new System.Windows.Forms.Label();
            this.easyBtn = new System.Windows.Forms.Button();
            this.normalBtn = new System.Windows.Forms.Button();
            this.hardBrn = new System.Windows.Forms.Button();
            this.ultimateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseLabel.ForeColor = System.Drawing.Color.White;
            this.chooseLabel.Location = new System.Drawing.Point(118, 41);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(307, 40);
            this.chooseLabel.TabIndex = 0;
            this.chooseLabel.Text = "Choose difficulty:";
            // 
            // easyBtn
            // 
            this.easyBtn.BackColor = System.Drawing.Color.SeaShell;
            this.easyBtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.easyBtn.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.easyBtn.Location = new System.Drawing.Point(46, 112);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(155, 78);
            this.easyBtn.TabIndex = 1;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = false;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            // 
            // normalBtn
            // 
            this.normalBtn.BackColor = System.Drawing.Color.SeaShell;
            this.normalBtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normalBtn.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.normalBtn.Location = new System.Drawing.Point(335, 112);
            this.normalBtn.Name = "normalBtn";
            this.normalBtn.Size = new System.Drawing.Size(155, 78);
            this.normalBtn.TabIndex = 2;
            this.normalBtn.Text = "Normal";
            this.normalBtn.UseVisualStyleBackColor = false;
            // 
            // hardBrn
            // 
            this.hardBrn.BackColor = System.Drawing.Color.SeaShell;
            this.hardBrn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hardBrn.ForeColor = System.Drawing.Color.SandyBrown;
            this.hardBrn.Location = new System.Drawing.Point(46, 257);
            this.hardBrn.Name = "hardBrn";
            this.hardBrn.Size = new System.Drawing.Size(155, 78);
            this.hardBrn.TabIndex = 3;
            this.hardBrn.Text = "Hard";
            this.hardBrn.UseVisualStyleBackColor = false;
            // 
            // ultimateBtn
            // 
            this.ultimateBtn.BackColor = System.Drawing.Color.SeaShell;
            this.ultimateBtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ultimateBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.ultimateBtn.Location = new System.Drawing.Point(335, 257);
            this.ultimateBtn.Name = "ultimateBtn";
            this.ultimateBtn.Size = new System.Drawing.Size(155, 78);
            this.ultimateBtn.TabIndex = 4;
            this.ultimateBtn.Text = "Ultimate";
            this.ultimateBtn.UseVisualStyleBackColor = false;
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.ultimateBtn);
            this.Controls.Add(this.hardBrn);
            this.Controls.Add(this.normalBtn);
            this.Controls.Add(this.easyBtn);
            this.Controls.Add(this.chooseLabel);
            this.Name = "Difficulty";
            this.Size = new System.Drawing.Size(559, 417);
            this.Load += new System.EventHandler(this.Difficulty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Button normalBtn;
        private System.Windows.Forms.Button hardBrn;
        private System.Windows.Forms.Button ultimateBtn;
    }
}
