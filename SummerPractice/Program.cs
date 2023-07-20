using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medium a = new Medium();
            Hard H= new Hard();
            H.ValidHexCode("#123abC");
            Console.WriteLine(a.ArrayOfMultiplaces(8, 7));
           Console.WriteLine( a.ReverseCase("HelloWorld"));
            Console.ReadKey();

        }
    }
}
