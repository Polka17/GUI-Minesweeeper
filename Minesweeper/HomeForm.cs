﻿using System;
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
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }
        private void homeForm_Load(object sender, EventArgs e)
        {
          
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            levelForm levelform = new levelForm();
            this.Hide();
            levelform.ShowDialog();
            this.Close();
        }
    }
}
