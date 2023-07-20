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
            VeryHard VH= new VeryHard();
           Console.WriteLine(VH.Simplify("1260/120"));
            H.ValidHexCode("#123BbC");
            Console.WriteLine(a.ArrayOfMultiplaces(8, 7));
           Console.WriteLine( a.ReverseCase("HelloWorld"));
            Console.ReadKey();

        }
    }
}
