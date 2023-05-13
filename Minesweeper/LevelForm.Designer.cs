
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
            this.difficulty1 = new Minesweeper.Difficulty();
            this.menu.SuspendLayout();
            this.infoPanel.SuspendLayout();
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
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.difficulty1);
            this.infoPanel.Location = new System.Drawing.Point(0, 51);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(545, 365);
            this.infoPanel.TabIndex = 2;
            // 
            // difficulty1
            // 
            this.difficulty1.AutoSize = true;
            this.difficulty1.BackColor = System.Drawing.Color.DarkOrange;
            this.difficulty1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.difficulty1.Location = new System.Drawing.Point(0, 0);
            this.difficulty1.Name = "difficulty1";
            this.difficulty1.Size = new System.Drawing.Size(543, 363);
            this.difficulty1.TabIndex = 0;
            // 
            // levelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(546, 414);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menu;
            this.Name = "levelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose a level";
            this.Load += new System.EventHandler(this.levelForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem homeItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyItem;
        private System.Windows.Forms.ToolStripMenuItem scoresItem;
        private System.Windows.Forms.Panel infoPanel;
        internal Difficulty difficulty1;
    }
}