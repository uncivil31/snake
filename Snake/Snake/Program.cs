﻿using System;
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
            Point p1 = new Point(1, 3, '*');           
            p1.Draw();

            Point p2 = new Point(4, 5, '#');            
            p2.Draw();

            HorizontalLIne line = new HorizontalLIne(5, 10, 8, '+');
            line.Drow();

            VerticalLine line2 = new VerticalLine(5, 10, 8, '+');
            line2.Drow();

            Console.ReadLine();
        }
    }
}
