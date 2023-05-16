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
    public partial class endForm : Form
    {
        homeForm homeForm = new homeForm();
        private int score;
        private int tries;
        private string message;

        public endForm(int scoreC, int triesC, string messageC)
        {
            InitializeComponent();
            score = scoreC;
            tries = triesC;
            message = messageC;
        }

        private void endForm_Load(object sender, EventArgs e)
        {
            scorePanel.Visible = false;

            scoreTB.Text = score.ToString();
            triesTB.Text = tries.ToString();
            label1.Text = message;
        }
        private void homeItem_Click_1(object sender, EventArgs e)
        {
            homeForm homeForm = new homeForm();
            this.Hide();
            homeForm.ShowDialog();
            this.Close();
        }
        private void scoresItem_Click(object sender, EventArgs e)
        {
            scorePanel.Visible = true;
            scorePanel.Dock = DockStyle.Fill;

            scoresRTB.Size = new Size(320, 220);
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
        private void yourScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scorePanel.Visible = false;
        }
        private void saveInfoBtn_Click(object sender, EventArgs e)
        {
            
            string searchText = usernameTB.Text;
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string newText = $"{usernameTB.Text},{score},{tries},{time}";


            using (StreamWriter writer = new StreamWriter("../file.txt", true))
            {
                writer.WriteLine(newText);
            }
            this.Hide();
            homeForm.ShowDialog();
            this.Close();
        }
    }
}
