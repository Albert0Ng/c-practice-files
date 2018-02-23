using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Fighter Ryoma = new Fighter("Ryoma", 450, 150, 100, 200, 50);
            Fighter Xander = new Fighter("Xander", 500, 100, 100, 100, 150);
            Battle battle1 = new Battle(Ryoma, Xander);
            Console.ReadLine();
        }
    }
}
