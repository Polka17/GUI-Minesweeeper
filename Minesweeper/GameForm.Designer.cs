
namespace Minesweeper
{
    partial class gameForm
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.triesLabel = new System.Windows.Forms.Label();
            this.scoreTB = new System.Windows.Forms.TextBox();
            this.triesTB = new System.Windows.Forms.TextBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.bombsLabel = new System.Windows.Forms.Label();
            this.bombsTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(11, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(64, 21);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score:";
            // 
            // triesLabel
            // 
            this.triesLabel.AutoSize = true;
            this.triesLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.triesLabel.ForeColor = System.Drawing.Color.White;
            this.triesLabel.Location = new System.Drawing.Point(13, 71);
            this.triesLabel.Name = "triesLabel";
            this.triesLabel.Size = new System.Drawing.Size(57, 21);
            this.triesLabel.TabIndex = 2;
            this.triesLabel.Text = "Tries:";
            // 
            // scoreTB
            // 
            this.scoreTB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreTB.ForeColor = System.Drawing.Color.White;
            this.scoreTB.Location = new System.Drawing.Point(11, 29);
            this.scoreTB.Name = "scoreTB";
            this.scoreTB.ReadOnly = true;
            this.scoreTB.Size = new System.Drawing.Size(61, 28);
            this.scoreTB.TabIndex = 3;
            // 
            // triesTB
            // 
            this.triesTB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.triesTB.ForeColor = System.Drawing.Color.White;
            this.triesTB.Location = new System.Drawing.Point(12, 96);
            this.triesTB.Name = "triesTB";
            this.triesTB.ReadOnly = true;
            this.triesTB.Size = new System.Drawing.Size(61, 28);
            this.triesTB.TabIndex = 4;
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.SeaShell;
            this.quitButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitButton.ForeColor = System.Drawing.Color.Orange;
            this.quitButton.Location = new System.Drawing.Point(5, 208);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(77, 55);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // bombsLabel
            // 
            this.bombsLabel.AutoSize = true;
            this.bombsLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bombsLabel.ForeColor = System.Drawing.Color.White;
            this.bombsLabel.Location = new System.Drawing.Point(6, 140);
            this.bombsLabel.Name = "bombsLabel";
            this.bombsLabel.Size = new System.Drawing.Size(75, 21);
            this.bombsLabel.TabIndex = 6;
            this.bombsLabel.Text = "Bombs:";
            // 
            // bombsTB
            // 
            this.bombsTB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bombsTB.ForeColor = System.Drawing.Color.White;
            this.bombsTB.Location = new System.Drawing.Point(13, 164);
            this.bombsTB.Name = "bombsTB";
            this.bombsTB.ReadOnly = true;
            this.bombsTB.Size = new System.Drawing.Size(61, 28);
            this.bombsTB.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.bombsTB);
            this.panel1.Controls.Add(this.bombsLabel);
            this.panel1.Controls.Add(this.quitButton);
            this.panel1.Controls.Add(this.triesTB);
            this.panel1.Controls.Add(this.scoreTB);
            this.panel1.Controls.Add(this.triesLabel);
            this.panel1.Controls.Add(this.scoreLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(637, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 512);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 512);
            this.panel2.TabIndex = 1;
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(722, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "gameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label triesLabel;
        private System.Windows.Forms.TextBox scoreTB;
        private System.Windows.Forms.TextBox triesTB;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label bombsLabel;
        private System.Windows.Forms.TextBox bombsTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}