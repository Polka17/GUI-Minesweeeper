using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class levelForm : Form
    {
        homeForm homeForm = new homeForm();

        public levelForm()
        {
            InitializeComponent();
        }

        private void levelForm_Load(object sender, EventArgs e)
        {
            difficultyPanel.Visible = false;
            infoPanel.Visible = true;
            infoPanel.Dock = DockStyle.Fill;
        }

        private void homeItem_Click(object sender, EventArgs e)
        {
            this.Close();
            homeForm.Show();
        }

        private void difficultyItem_Click(object sender, EventArgs e)
        {
            difficultyPanel.Dock = DockStyle.Fill;
            difficultyPanel.Visible = true;

            infoPanel.Visible = false;
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
    }
}
