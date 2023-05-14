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
            homeForm.FormClosed += HomeForm_FormClosed;
            homeForm.Show();

            endForm endForm = new endForm(0, 0, "");
            endForm.FormClosed += EndForm_FormClosed;
            this.Hide();
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
            gameForm.Show();

            this.Visible = false;
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            gameForm gameForm = new gameForm(8, 32);
            gameForm.Show();

            this.Visible = false;
        }

        private void hardBrn_Click(object sender, EventArgs e)
        {
            gameForm gameForm = new gameForm(11, 40);
            gameForm.Show();

            this.Visible = false;
        }

        private void ultimateBtn_Click(object sender, EventArgs e)
        {
            gameForm gameForm = new gameForm(15, 110);
            gameForm.Show();

            this.Visible = false;
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

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close this form if home form is closed
            Close();
        }
        private void EndForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close this form if home form is closed
            Close();
        }
    }
}
