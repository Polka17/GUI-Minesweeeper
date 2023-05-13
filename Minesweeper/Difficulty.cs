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
    public partial class Difficulty : UserControl
    {
        public int GameSize { get; set; }
        public int Bombs { get; set; }
        public Difficulty()
        {
            InitializeComponent();
        }

        private void Difficulty_Load(object sender, EventArgs e)
        {
            
        }
        private void easyBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GameSize = 7;
            Bombs = 8;
            GameInterface gameInterface = new GameInterface();
            gameInterface.Visible = true;
        }
    }
}
