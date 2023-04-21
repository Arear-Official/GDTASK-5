using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gd5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];
            
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                mass[i] = random.Next(0, 10);
            }
            int[] massb = mass;
            mass = mass.Reverse().ToArray();
            mass = mass.Distinct().ToArray();
            mass = mass.Reverse().ToArray();
            Console.WriteLine(string.Join(", ", massb));
            Console.WriteLine(string.Join(", ", mass)) ;
        }
    }
}
