using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice
{
     public class Medium
    {
        //Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num until the array length reaches length.
        public int[] ArrayOfMultiplaces(int num, int lenght) 
        {
            int[] array=new int[lenght];
            for (int i = 0; i < lenght; i++) 
            {
                array[i] = num;
                num = num * 2;
            }
            return array;
        }
        //Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
        public string ReverseCase(string str) 
        {
            char[] chars = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                
                if (char.IsUpper(chars[i])) 
                {
                    chars[i] = char.ToLower(chars[i]);
                }
                
               else if (char.IsLower(chars[i]))
               {
                    chars[i] = char.ToUpper(chars[i]);
               }
                
            }
            return new string(chars);
            

        }
    }
}
