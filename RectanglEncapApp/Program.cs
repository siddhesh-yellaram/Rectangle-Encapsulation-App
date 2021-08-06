using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectanglEncapApp.Model;

namespace RectanglEncapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(100, 120);
            Rectangle r2 = new Rectangle(120, 200, BorderStyle.DOTTED);

            Console.WriteLine(r1.getBorder());
            Console.WriteLine(r2.getBorder());

            Console.WriteLine(r1.calculateArea());
            Console.WriteLine(r2.calculateArea());

            Console.ReadLine();
        }
    }
}
