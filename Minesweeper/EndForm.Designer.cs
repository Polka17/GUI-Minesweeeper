
namespace Minesweeper
{
    partial class endForm
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
            this.scoresItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.triesLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.scoreTB = new System.Windows.Forms.TextBox();
            this.triesTB = new System.Windows.Forms.TextBox();
            this.saveInfoBtn = new System.Windows.Forms.Button();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.scoresRTB = new System.Windows.Forms.RichTextBox();
            this.menu.SuspendLayout();
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
            this.scoresItem,
            this.yourScoreToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(10);
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(487, 48);
            this.menu.TabIndex = 2;
            this.menu.Text = "Menu";
            // 
            // homeItem
            // 
            this.homeItem.Name = "homeItem";
            this.homeItem.Size = new System.Drawing.Size(77, 28);
            this.homeItem.Text = "Home";
            this.homeItem.Click += new System.EventHandler(this.homeItem_Click_1);
            // 
            // scoresItem
            // 
            this.scoresItem.Name = "scoresItem";
            this.scoresItem.Size = new System.Drawing.Size(82, 28);
            this.scoresItem.Text = "Scores";
            this.scoresItem.Click += new System.EventHandler(this.scoresItem_Click);
            // 
            // yourScoreToolStripMenuItem
            // 
            this.yourScoreToolStripMenuItem.Name = "yourScoreToolStripMenuItem";
            this.yourScoreToolStripMenuItem.Size = new System.Drawing.Size(118, 28);
            this.yourScoreToolStripMenuItem.Text = "Your score";
            this.yourScoreToolStripMenuItem.Click += new System.EventHandler(this.yourScoreToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "message";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(91, 220);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(94, 34);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score:";
            // 
            // triesLabel
            // 
            this.triesLabel.AutoSize = true;
            this.triesLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.triesLabel.ForeColor = System.Drawing.Color.White;
            this.triesLabel.Location = new System.Drawing.Point(295, 220);
            this.triesLabel.Name = "triesLabel";
            this.triesLabel.Size = new System.Drawing.Size(85, 34);
            this.triesLabel.TabIndex = 5;
            this.triesLabel.Text = "Tries:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(23, 158);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(233, 34);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Enter username: ";
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.Color.White;
            this.usernameTB.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTB.ForeColor = System.Drawing.Color.Black;
            this.usernameTB.Location = new System.Drawing.Point(252, 158);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(199, 40);
            this.usernameTB.TabIndex = 7;
            // 
            // scoreTB
            // 
            this.scoreTB.BackColor = System.Drawing.Color.White;
            this.scoreTB.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreTB.Location = new System.Drawing.Point(85, 257);
            this.scoreTB.Name = "scoreTB";
            this.scoreTB.ReadOnly = true;
            this.scoreTB.Size = new System.Drawing.Size(100, 40);
            this.scoreTB.TabIndex = 8;
            // 
            // triesTB
            // 
            this.triesTB.BackColor = System.Drawing.Color.White;
            this.triesTB.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.triesTB.Location = new System.Drawing.Point(289, 257);
            this.triesTB.Name = "triesTB";
            this.triesTB.ReadOnly = true;
            this.triesTB.Size = new System.Drawing.Size(100, 40);
            this.triesTB.TabIndex = 9;
            // 
            // saveInfoBtn
            // 
            this.saveInfoBtn.BackColor = System.Drawing.Color.SeaShell;
            this.saveInfoBtn.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveInfoBtn.ForeColor = System.Drawing.Color.Orange;
            this.saveInfoBtn.Location = new System.Drawing.Point(158, 321);
            this.saveInfoBtn.Name = "saveInfoBtn";
            this.saveInfoBtn.Size = new System.Drawing.Size(157, 51);
            this.saveInfoBtn.TabIndex = 10;
            this.saveInfoBtn.Text = "Save";
            this.saveInfoBtn.UseVisualStyleBackColor = false;
            this.saveInfoBtn.Click += new System.EventHandler(this.saveInfoBtn_Click);
            // 
            // scorePanel
            // 
            this.scorePanel.Controls.Add(this.scoresRTB);
            this.scorePanel.Location = new System.Drawing.Point(261, 52);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(200, 100);
            this.scorePanel.TabIndex = 11;
            // 
            // scoresRTB
            // 
            this.scoresRTB.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoresRTB.Location = new System.Drawing.Point(28, 21);
            this.scoresRTB.Name = "scoresRTB";
            this.scoresRTB.Size = new System.Drawing.Size(100, 96);
            this.scoresRTB.TabIndex = 0;
            this.scoresRTB.Text = "";
            // 
            // endForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(487, 384);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.saveInfoBtn);
            this.Controls.Add(this.triesTB);
            this.Controls.Add(this.scoreTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.triesLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Name = "endForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndForm";
            this.Load += new System.EventHandler(this.endForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.scorePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem homeItem;
        private System.Windows.Forms.ToolStripMenuItem scoresItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label triesLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox scoreTB;
        private System.Windows.Forms.TextBox triesTB;
        private System.Windows.Forms.Button saveInfoBtn;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.RichTextBox scoresRTB;
        private System.Windows.Forms.ToolStripMenuItem yourScoreToolStripMenuItem;
    }
}