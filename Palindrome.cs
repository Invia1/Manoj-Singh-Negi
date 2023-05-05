using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static Boolean isPalindorme(char[] character)
        {
            if(character.Length == 0)
            {
                return false;
            }
            int start = 0;
            int end = character.Length-1;
            while(start<end)
            {
                if (!(character[start] == character[end]))
                {
                    return false;
                }
              
                start++;
                end--;
            }
            
            return true;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name : ");
            string name = Console.ReadLine();
            name.ToLower();
            char[] name1 = name.ToCharArray();
            Console.WriteLine(isPalindorme(name1));

        }
    }
}
