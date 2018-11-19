using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tetris
{
    class Cube
    {
        public PictureBox rec { get; }
        public bool IsNull { get; set; }
        public Cube(Color color)
        {
            IsNull = false;
            rec = new PictureBox();
            rec.Width = Board.cubeSize;
            rec.Height = Board.cubeSize;
            rec.BackColor = color;
            rec.Left = 0;
            rec.Top = 0;
        }
        public Cube(bool Null = true)
        {
            if (Null)
            {
                IsNull = true;
                rec = new PictureBox();
                rec.Width = Board.cubeSize;
                rec.Height = Board.cubeSize;
                rec.BackColor = Color.Transparent;
                rec.Left = 0;
                rec.Top = 0;
            }
            else
            {
                IsNull = false;
                rec = new PictureBox();
                rec.Width = Board.cubeSize;
                rec.Height = Board.cubeSize;
                rec.BackColor = Color.Black;
                rec.Left = 0;
                rec.Top = 0;
            }
        }
        public int Left
        {
            get => rec.Left;
            set => rec.Left = value;
        }

        public int Top
        {
            get => rec.Top;
            set => rec.Top = value;
        }
    }
}
