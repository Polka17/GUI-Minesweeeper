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
    //make user controls forms for easier data sharing
    public partial class levelForm : Form
    {
        homeForm homeForm = new homeForm();
        public levelForm()
        {
            InitializeComponent();
        }

        private void levelForm_Load(object sender, EventArgs e)
        {
            difficulty1.Visible = false;
        }

        private void homeItem_Click(object sender, EventArgs e)
        {
            //hide this form
            this.Close();
            //Initialise home form, so as to be able to show it
            homeForm.Show();
        }

        private void difficultyItem_Click(object sender, EventArgs e)
        {
            //Make the Choose difficulty UC appear
            difficulty1.Visible = true;
        }
    }
}
