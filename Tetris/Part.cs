using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    
    public enum Shapes
    {
        line, z, s, t, square
    }
    class Part
    {
        private Shapes x;
        private Random rand = new Random();
        public Cube[,] part { get; set; }
        private static Cube[,] line = new Cube[Board.height,Board.width];
        private static Cube[,] z = new Cube[Board.height, Board.width];
        private static Cube[,] s = new Cube[Board.height, Board.width];
        private static Cube[,] square = new Cube[Board.height, Board.width];
        private static Cube[,] t = new Cube[Board.height, Board.width];
        public static void Initiate()
        {
            //line
            for (int y = 0; y < Board.height; y++)
            {
                for (int x = 0; x < Board.width; x++)
                {
                    line[y, x] = new Cube();
                }
            }
            line[0, Board.width / 2 - 2 - 1] = new Cube(System.Drawing.Color.Red);
            line[0, Board.width / 2 - 1 - 1] = new Cube(System.Drawing.Color.Red);
            line[0, Board.width / 2 - 1] = new Cube(System.Drawing.Color.Red);
            line[0, Board.width / 2 + 1 - 1] = new Cube(System.Drawing.Color.Red);

            z = new Cube[3, 3];

            square = new Cube[2, 2];
            line[1, Board.width / 2 - 1 - 1] = new Cube(System.Drawing.Color.Red);
            line[0, Board.width / 2 - 1 - 1] = new Cube(System.Drawing.Color.Red);
            line[0, Board.width / 2 - 1] = new Cube(System.Drawing.Color.Red);
            line[1, Board.width / 2 - 1 - 1] = new Cube(System.Drawing.Color.Red);
        }

        public Part()
        {

            //x = (Shapes)rand.Next(0, 4);
            x = Shapes.line;
            switch (x)
            {
                case Shapes.line:
                    {
                        part = line;
                        break;
                    }
                    
                case Shapes.z:
                    break;
                case Shapes.s:
                    break;
                case Shapes.t:
                    break;
                case Shapes.square:
                    break;
                default:
                    break;
            }
        }
    }
}
