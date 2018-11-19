using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        private Timer t = new Timer();
        
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Height = Board.height * Board.cubeSize;
            Width = Board.width * Board.cubeSize;
            Part.Initiate();
            Board b = new Board();
            Controls.Clear();
            Cube[,] ba = b.GetBoard();
            for (int y = 0; y < Board.height; y++)
            {
                for (int x = 0; x < Board.width; x++)
                {
                    ba[y, x].Left = Board.cubeSize*x;
                    ba[y, x].Top = Board.cubeSize * y;
                    Controls.Add(ba[y, x].rec);
                }
            }
        }
    }
}
