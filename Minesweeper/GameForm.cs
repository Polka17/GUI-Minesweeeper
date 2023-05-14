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
    public partial class gameForm : Form
    {
        private int[,] cells;
        private Button[,] buttons;
        private int tries;
        private int score;

        private int gameSize = 0;
        private int bombs = 0;

        public gameForm(int size, int bombsC)
        {
            InitializeComponent();
            gameSize = size;
            bombs = bombsC;
        }
        private void gameForm_Load(object sender, EventArgs e)
        {
            Initialise(gameSize, bombs);

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    Button button = new Button();
                    buttons[i, j] = button;
                    button.BackColor = Color.Orange;
                    button.Left = i * 40;
                    button.Top = j * 40;
                    button.Width = 40;
                    button.Height = 40;
                    button.Text = "";
                    button.Font = new Font("Arial", 20);
                    panel2.Controls.Add(button);
                    button.Click += ButtonClick; ;
                }
            }
        }
        private void Initialise(int size, int bombs)
        {
            cells = new int[size, size];
            buttons = new Button[size, size];
            tries = bombs;

            Random random = new Random();
            while (bombs > 0)
            {
                int row = random.Next(size);
                int col = random.Next(size);
                if (cells[row, col] == -1)
                {
                    continue;
                }
                cells[row, col] = -1;
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (row + i < 0 || col + j < 0 || row + i >= size || col + j >= size)
                        {
                            continue;
                        }
                        if (cells[row + i, col + j] != -1)
                        {
                            cells[row + i, col + j]++;
                        }
                    }
                }
                bombs--;
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int row = button.Left / 40;
            int col = button.Top / 40;
            if (cells[row, col] == -1)
            {
                button.Text = "\U0001F4A3";
                score += 10;
                bombs--;
                scoreTB.Text = score.ToString();
                bombsTB.Text = bombs.ToString();
                if (bombs <= 0)
                {
                    this.Close();
                    endForm endForm = new endForm(score, tries, "Game over! You won!!!");
                    endForm.Show();
                }
            }
            else
            {
                if (cells[row, col] == 0)
                {
                    button.Text = "";
                    Reveal(row, col);
                    tries--;
                    triesTB.Text = tries.ToString();
                    if (tries <= 0)
                    {
                        this.Close();
                        endForm endForm = new endForm(score, tries, "Game over! You lose!!");
                        endForm.Show();
                    }
                }
                else
                {
                    button.Text = $"{cells[row, col]}";
                    tries--;
                    triesTB.Text = tries.ToString();
                    if (tries <= 0)
                    {
                        this.Close();
                        endForm endForm = new endForm(score, tries, "Game over! You lose!!");
                        endForm.Show();
                    }
                }
            }
            button.Enabled = false;
        }

        //Reveal not needed
        private void Reveal(int row, int col)
        {
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(row, col));
            while (stack.Count > 0)
            {
                Point point = stack.Pop();
                if (point.X < 0 || point.Y < 0 || point.X >= cells.GetLength(0) || point.Y >= cells.GetLength(1))
                {
                    continue;
                }
                if (!buttons[point.X, point.Y].Enabled)
                {
                    continue;
                }
                buttons[point.X, point.Y].Enabled = false;
                if (cells[point.X, point.Y] == 0)
                {
                    buttons[point.X, point.Y].BackColor = Color.CornflowerBlue;
                }
                if (cells[point.X, point.Y] != 0)
                {
                    buttons[point.X, point.Y].Text = $"{cells[point.X, point.Y]}"; 
                    continue;
                }
                stack.Push(new Point(point.X - 1, point.Y));
                stack.Push(new Point(point.X + 1, point.Y));
                stack.Push(new Point(point.X, point.Y - 1));
                stack.Push(new Point(point.X, point.Y + 1));
            }
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
