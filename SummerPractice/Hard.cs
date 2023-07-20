using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice
{
     class Hard
    {
        // Create a function that determines whether a string is a valid hex code.
        // A hex code must begin with a pound key # and is exactly 6 characters in length. Each character must be a digit from 0-9 or an alphabetic character from A-F. All alphabetic characters may be uppercase or lowercase.

        public void ValidHexCode(string str) 
        {
            bool IsValid = true;
            str = str.ToLower();
            char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if (str[0] != '#' || str.Length != 7)
            {
                IsValid=false;
            }
            for (int i = 1; i < str.Length; i++) 
            {
                int j = 0;
                while (j < chars.Length && str[i] != chars[j])
                {
                    j++;
                }
                if (j == chars.Length) 
                {
                    IsValid = false;
                }
            }
            
            if (IsValid) 
            {
                Console.WriteLine("true");

            }
            else
            {   
                Console.WriteLine("false");
            }
        }
    }
}
