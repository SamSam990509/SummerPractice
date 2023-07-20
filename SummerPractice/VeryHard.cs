using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice
{
     class VeryHard
    {
        //Create a function that returns the simplified version of a fraction.

        public string Simplify(string str) 
        {

            string[] array = str.Split('/');

            int a =int.Parse(array[0]);
            int b = int.Parse(array[1]);

            int smaler;

            if (a > b) 
            {
                 smaler = b;
            }
            else 
            {
                smaler=a;
            }
            int i = 1;
            while(i<smaler)  
            {
                i++;
                if (a % i == 0 && b % i == 0) 
                {

                    a = a / i;
                    b = b / i;
                    i = 1;
                }
            }
            string result = $"{a}/{b}";
            if (a % b == 0) 
            {

                result = $"{a / b}";
            }
            
            return result ;
        }
    }
}

