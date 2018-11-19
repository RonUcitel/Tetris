using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    class Board
    {
        private Timer down;
        private Cube[,] board;
        public const int cubeSize = 25, width = 10, height = 18;
        private Part p = new Part();


        public Board()
        {
            board = new Cube[18, 10];
            down = new Timer();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    board[y, x] = new Cube();
                }
            }
            //down.set
        }

        public bool MovePartLeft()
        {
            if (true)
            {

            }
            return false;
        }
        private Cube Or(Cube a, Cube b)// => a.IsNull ? (b.IsNull ? null : b) : a;
        {
            if (a.IsNull && b.IsNull)
            {
                return new Cube(true); //both are null
            }
            return a.IsNull ? b : a;
        }
        public Cube[,] GetBoard()
        {
            Cube[,] output = board;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    output[y,x] = Or(p.part[y, x], output[y, x]);
                }
            }
            return output;
        }
    }
}
