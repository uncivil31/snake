using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLIne lineTop = new HorizontalLIne(0, 78, 0, '+');
            HorizontalLIne lineBottom = new HorizontalLIne(0, 78, 24, '+');
            VerticalLine lineLeft = new VerticalLine(0, 24, 0, '+');
            VerticalLine lineRight = new VerticalLine(0, 24, 78, '+');
            lineTop.Drow();
            lineBottom.Drow();
            lineLeft.Drow();
            lineRight.Drow();

            Point p = new Point(3, 3, '*');
            p.Draw();

            Console.ReadLine();
        }
    }
}
