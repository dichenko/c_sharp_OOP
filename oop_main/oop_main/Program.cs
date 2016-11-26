using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_main
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw(2, 4, '&');
            Draw(6, 6, '%');


            Console.ReadLine();


        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}
