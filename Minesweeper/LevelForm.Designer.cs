
namespace Minesweeper
{
    partial class levelForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.homeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.difficultyPanel = new System.Windows.Forms.Panel();
            this.ultimateBtn = new System.Windows.Forms.Button();
            this.hardBrn = new System.Windows.Forms.Button();
            this.normalBtn = new System.Windows.Forms.Button();
            this.easyBtn = new System.Windows.Forms.Button();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.scoresRTB = new System.Windows.Forms.RichTextBox();
            this.menu.SuspendLayout();
            this.difficultyPanel.SuspendLayout();
            this.scorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.SeaShell;
            this.menu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeItem,
            this.difficultyItem,
            this.scoresItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(10);
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(546, 48);
            this.menu.TabIndex = 1;
            this.menu.Text = "Menu";
            // 
            // homeItem
            // 
            this.homeItem.Name = "homeItem";
            this.homeItem.Size = new System.Drawing.Size(77, 28);
            this.homeItem.Text = "Home";
            this.homeItem.Click += new System.EventHandler(this.homeItem_Click);
            // 
            // difficultyItem
            // 
            this.difficultyItem.Name = "difficultyItem";
            this.difficultyItem.Size = new System.Drawing.Size(102, 28);
            this.difficultyItem.Text = "Difficulty";
            this.difficultyItem.Click += new System.EventHandler(this.difficultyItem_Click);
            // 
            // scoresItem
            // 
            this.scoresItem.Name = "scoresItem";
            this.scoresItem.Size = new System.Drawing.Size(82, 28);
            this.scoresItem.Text = "Scores";
            this.scoresItem.Click += new System.EventHandler(this.scoresItem_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Location = new System.Drawing.Point(12, 66);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(200, 238);
            this.infoPanel.TabIndex = 2;
            // 
            // difficultyPanel
            // 
            this.difficultyPanel.Controls.Add(this.ultimateBtn);
            this.difficultyPanel.Controls.Add(this.hardBrn);
            this.difficultyPanel.Controls.Add(this.normalBtn);
            this.difficultyPanel.Controls.Add(this.easyBtn);
            this.difficultyPanel.Controls.Add(this.chooseLabel);
            this.difficultyPanel.Location = new System.Drawing.Point(228, 112);
            this.difficultyPanel.Name = "difficultyPanel";
            this.difficultyPanel.Size = new System.Drawing.Size(423, 351);
            this.difficultyPanel.TabIndex = 0;
            // 
            // ultimateBtn
            // 
            this.ultimateBtn.BackColor = System.Drawing.Color.SeaShell;
            this.ultimateBtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ultimateBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.ultimateBtn.Location = new System.Drawing.Point(338, 250);
            this.ultimateBtn.Name = "ultimateBtn";
            this.ultimateBtn.Size = new System.Drawing.Size(155, 78);
            this.ultimateBtn.TabIndex = 9;
            this.ultimateBtn.Text = "Ultimate";
            this.ultimateBtn.UseVisualStyleBackColor = false;
            this.ultimateBtn.Click += new System.EventHandler(this.ultimateBtn_Click);
            // 
            // hardBrn
            // 
            this.hardBrn.BackColor = System.Drawing.Color.SeaShell;
            this.hardBrn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hardBrn.ForeColor = System.Drawing.Color.SandyBrown;
            this.hardBrn.Location = new System.Drawing.Point(49, 250);
            this.hardBrn.Name = "hardBrn";
            this.hardBrn.Size = new System.Drawing.Size(155, 78);
            this.hardBrn.TabIndex = 8;
            this.hardBrn.Text = "Hard";
            this.hardBrn.UseVisualStyleBackColor = false;
            this.hardBrn.Click += new System.EventHandler(this.hardBrn_Click);
            // 
            // normalBtn
            // 
            this.normalBtn.BackColor = System.Drawing.Color.SeaShell;
            this.normalBtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normalBtn.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.normalBtn.Location = new System.Drawing.Point(338, 105);
            this.normalBtn.Name = "normalBtn";
            this.normalBtn.Size = new System.Drawing.Size(155, 78);
            this.normalBtn.TabIndex = 7;
            this.normalBtn.Text = "Normal";
            this.normalBtn.UseVisualStyleBackColor = false;
            this.normalBtn.Click += new System.EventHandler(this.normalBtn_Click);
            // 
            // easyBtn
            // 
            this.easyBtn.BackColor = System.Drawing.Color.SeaShell;
            this.easyBtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.easyBtn.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.easyBtn.Location = new System.Drawing.Point(49, 105);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(155, 78);
            this.easyBtn.TabIndex = 6;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = false;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseLabel.ForeColor = System.Drawing.Color.White;
            this.chooseLabel.Location = new System.Drawing.Point(121, 34);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(307, 40);
            this.chooseLabel.TabIndex = 5;
            this.chooseLabel.Text = "Choose difficulty:";
            // 
            // scorePanel
            // 
            this.scorePanel.Controls.Add(this.scoresRTB);
            this.scorePanel.Location = new System.Drawing.Point(36, 321);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(200, 100);
            this.scorePanel.TabIndex = 3;
            // 
            // scoresRTB
            // 
            this.scoresRTB.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoresRTB.Location = new System.Drawing.Point(27, 23);
            this.scoresRTB.Name = "scoresRTB";
            this.scoresRTB.Size = new System.Drawing.Size(100, 96);
            this.scoresRTB.TabIndex = 0;
            this.scoresRTB.Text = "";
            // 
            // levelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(546, 414);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.difficultyPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "levelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose a level";
            this.Load += new System.EventHandler(this.levelForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.difficultyPanel.ResumeLayout(false);
            this.difficultyPanel.PerformLayout();
            this.scorePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem homeItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyItem;
        private System.Windows.Forms.ToolStripMenuItem scoresItem;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel difficultyPanel;
        private System.Windows.Forms.Button ultimateBtn;
        private System.Windows.Forms.Button hardBrn;
        private System.Windows.Forms.Button normalBtn;
        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.RichTextBox scoresRTB;
    }
}