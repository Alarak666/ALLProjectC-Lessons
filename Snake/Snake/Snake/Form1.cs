using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private int ri, rj;
        private PictureBox [] snake = new PictureBox[400];
        private PictureBox Fresh;
        private int _Widht = 800;
        private int _Height = 800;
        private int MoveX, MoveY;
        private int SizeBlock = 40;
        private int score = 0;
        public Form1()
        { 
            InitializeComponent();
            this.Width = 1000;
            this.Height = 800;
            GeneralMap();
            Fresh = new PictureBox();
            Fresh.BackColor = Color.Red;
            Fresh.Size = new Size(40,40);
            snake[0] = new PictureBox();
            snake[0].Location = new Point(0,0);
            snake[0].Size = new Size(SizeBlock, SizeBlock);
            snake[0].BackColor = Color.Blue;
            this.Controls.Add(snake[0]);
            GeneralFresh();
            timer1.Tick += new EventHandler(_Update);
            timer1.Interval = 500;
            timer1.Start();
            this.KeyDown += new KeyEventHandler(InputMoves);
        }
        private void GeneralMap()
        {
            for (int i = 0; i < _Widht / SizeBlock; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Black;
                pictureBox.Location = new Point(0, SizeBlock * i);
                pictureBox.Size = new Size(_Widht - 40, 1);
                this.Controls.Add(pictureBox);
            }
            for (int i = 0; i < _Height / SizeBlock; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Black;
                pictureBox.Location = new Point(SizeBlock * i, 0);
                pictureBox.Size = new Size(1, _Height - 40);
                this.Controls.Add(pictureBox);
            }
        }
        private void GeneralFresh()
        {
            Random random = new Random();
            ri = random.Next(0, _Widht - SizeBlock);
            int tempi = ri % SizeBlock;
            ri -= tempi;
            rj = random.Next(0, _Height - SizeBlock);
            int tempj = rj % SizeBlock;
            ri -= tempj;
            Fresh.Location = new Point(ri, rj);
            this.Controls.Add(Fresh);
        }
        private void InputMoves(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode.ToString())
            {
                case "Right":
                    MoveX = 1;
                    MoveY = 0;
                    break;
                case "Left":
                    MoveX = -1;
                    MoveY = 0;
                    break;
                case "Up":
                    MoveY = -1;
                    MoveX = 0;
                    break;
                case "Down":
                    MoveY = 1;
                    MoveX = 0;
                    break;
            }
        }
        private void SnakeMove()
        {
            for (int i = score; i >= 0; i--)
            {
                snake[i].Location = new Point(snake[i].Location.X + MoveX * SizeBlock, snake[i].Location.Y + MoveY * SizeBlock);
            }
        }
        private void _Update(object sender, EventArgs e)
        {
            SnakeMove();
        }
    }
}
