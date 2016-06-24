using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(5, 6, '*');
            p.Draw();

            Console.ReadLine();
        }
    }
}
