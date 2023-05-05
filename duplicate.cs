using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void duplicate(char[] list)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach(char ch in list)
            {
                if (dic.ContainsKey(ch))
                {
                    dic[ch] = dic[ch]+1;
                }
                else
                {
                    dic.Add(ch, 1);
                }
            }
            foreach(KeyValuePair<char,int> pair in dic)
            {
              
                    Console.WriteLine("{0} repeats  {1} times", pair.Key, pair.Value);
                
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name : ");
            string name = Console.ReadLine();
            name.ToLower();
            char[] name1 = name.ToCharArray();
            duplicate(name1);

        }
    }
}
