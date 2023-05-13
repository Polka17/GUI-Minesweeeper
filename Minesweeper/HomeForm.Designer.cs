
namespace Minesweeper
{
    partial class homeForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.bomb1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bomb5 = new System.Windows.Forms.PictureBox();
            this.bomb4 = new System.Windows.Forms.PictureBox();
            this.bomb3 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.bomb2 = new System.Windows.Forms.PictureBox();
            this.bomb7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bomb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(192, 98);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(313, 56);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "MINESWEEPER\r\n";
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.AutoSize = true;
            this.subTitleLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLabel.Location = new System.Drawing.Point(243, 155);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(204, 43);
            this.subTitleLabel.TabIndex = 2;
            this.subTitleLabel.Text = "Polka Edition";
            // 
            // bomb1
            // 
            this.bomb1.Image = global::Minesweeper.Properties.Resources.littlebomb;
            this.bomb1.Location = new System.Drawing.Point(3, 1);
            this.bomb1.Name = "bomb1";
            this.bomb1.Size = new System.Drawing.Size(62, 52);
            this.bomb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomb1.TabIndex = 5;
            this.bomb1.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::Minesweeper.Properties.Resources.bomb;
            this.logo.Location = new System.Drawing.Point(-11, -11);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(297, 307);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // bomb5
            // 
            this.bomb5.Image = global::Minesweeper.Properties.Resources.littlebomb;
            this.bomb5.Location = new System.Drawing.Point(461, 1);
            this.bomb5.Name = "bomb5";
            this.bomb5.Size = new System.Drawing.Size(73, 63);
            this.bomb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomb5.TabIndex = 7;
            this.bomb5.TabStop = false;
            // 
            // bomb4
            // 
            this.bomb4.Image = global::Minesweeper.Properties.Resources.littlebomb;
            this.bomb4.Location = new System.Drawing.Point(410, 26);
            this.bomb4.Name = "bomb4";
            this.bomb4.Size = new System.Drawing.Size(57, 52);
            this.bomb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomb4.TabIndex = 8;
            this.bomb4.TabStop = false;
            // 
            // bomb3
            // 
            this.bomb3.Image = global::Minesweeper.Properties.Resources.littlebomb;
            this.bomb3.Location = new System.Drawing.Point(383, 1);
            this.bomb3.Name = "bomb3";
            this.bomb3.Size = new System.Drawing.Size(51, 39);
            this.bomb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomb3.TabIndex = 9;
            this.bomb3.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Coral;
            this.startButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(264, 219);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(149, 77);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // bomb2
            // 
            this.bomb2.Image = global::Minesweeper.Properties.Resources.littlebomb;
            this.bomb2.Location = new System.Drawing.Point(48, 25);
            this.bomb2.Name = "bomb2";
            this.bomb2.Size = new System.Drawing.Size(51, 39);
            this.bomb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomb2.TabIndex = 11;
            this.bomb2.TabStop = false;
            // 
            // bomb7
            // 
            this.bomb7.Image = global::Minesweeper.Properties.Resources.littlebomb;
            this.bomb7.Location = new System.Drawing.Point(490, 237);
            this.bomb7.Name = "bomb7";
            this.bomb7.Size = new System.Drawing.Size(44, 39);
            this.bomb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomb7.TabIndex = 12;
            this.bomb7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Minesweeper.Properties.Resources.littlebomb;
            this.pictureBox1.Location = new System.Drawing.Point(474, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(546, 318);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bomb7);
            this.Controls.Add(this.bomb2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.bomb3);
            this.Controls.Add(this.bomb4);
            this.Controls.Add(this.bomb5);
            this.Controls.Add(this.bomb1);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.homeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bomb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.PictureBox bomb1;
        private System.Windows.Forms.PictureBox bomb5;
        private System.Windows.Forms.PictureBox bomb4;
        private System.Windows.Forms.PictureBox bomb3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox bomb2;
        private System.Windows.Forms.PictureBox bomb7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

