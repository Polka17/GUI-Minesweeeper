using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class levelForm : Form
    {
        public levelForm()
        {
            InitializeComponent();
        }

        private void levelForm_Load(object sender, EventArgs e)
        {
            difficultyPanel.Visible = false;
            infoPanel.Visible = true;
            scorePanel.Visible = false;
            infoPanel.Dock = DockStyle.Fill;
        }

        private void homeItem_Click(object sender, EventArgs e)
        {
            homeForm homeForm = new homeForm();
            this.Hide();
            homeForm.ShowDialog();
            this.Close();
        }

        private void difficultyItem_Click(object sender, EventArgs e)
        {
            difficultyPanel.Dock = DockStyle.Fill;
            difficultyPanel.Visible = true;

            infoPanel.Visible = false;
            scorePanel.Visible = false;
        }


        private void easyBtn_Click(object sender, EventArgs e)
        {
            gameForm gameForm = new gameForm(5,15);
            this.Hide();
            gameForm.ShowDialog();
            this.Close();
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            gameForm gameForm = new gameForm(8, 32);
            this.Hide();
            gameForm.ShowDialog();
            this.Close();
        }

        private void hardBrn_Click(object sender, EventArgs e)
        {
            gameForm gameForm = new gameForm(11, 40);
            this.Hide();
            gameForm.ShowDialog();
            this.Close();
        }

        private void ultimateBtn_Click(object sender, EventArgs e)
        {
            gameForm gameForm = new gameForm(15, 110);
            this.Hide();
            gameForm.ShowDialog();
            this.Close();
        }

        private void scoresItem_Click(object sender, EventArgs e)
        {
            scorePanel.Visible = true;
            scorePanel.Dock = DockStyle.Fill;

            scoresRTB.Size = new Size(360, 250);
            scoresRTB.Margin = new Padding(10);

            using (StreamReader streamReader = new StreamReader("../file.txt"))
            {
                if(scoresRTB.Text != "")
                {
                    scoresRTB.Clear();
                }
                else
                {
                    while (!streamReader.EndOfStream)
                    {
                        scoresRTB.Text += streamReader.ReadLine();
                        scoresRTB.Text += Environment.NewLine;
                    }
                }
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoPanel.Visible = true;

            difficultyPanel.Visible = false;
            scorePanel.Visible = false;
        }
    }
}
