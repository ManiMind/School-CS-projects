using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pris_oversigt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("pris: ");
            int pris = Convert.ToInt32(Console.ReadLine());
            Console.Write("styk: ");
            int styk = Convert.ToInt32(Console.ReadLine());
            int x = 0;

            while (x < styk)
            {
                x++;
                Console.WriteLine(x + "\t\t\t" + (x * pris) + ",-\t\toui!");
                Thread.Sleep(100);
            }
            Console.ReadLine();
        }
    }
}
