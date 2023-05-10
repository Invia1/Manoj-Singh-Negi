using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Journey
    {

        Object[] myStuff = new object[5];

        public Object this[int i]
        {
            get
            { return myStuff[i]; }
            set
            { myStuff[i] = value; }
        }

        public void notTravel()
        {
            Console.WriteLine("you can not travel bcoz you dont have enough money for travel");
        }
        public void travel()
        {
            Console.WriteLine("you can  travel bcoz you have enough money for travel");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Journey j = new Journey();

            int a = 1;
            Console.WriteLine("enter your stuff :");
            for (int i = 0; i < 5; i++)
            {
                if (a == 5)
                {
                    Console.WriteLine("you should enter the amout");
                }
                j[i] = Console.ReadLine();
                a++;
            }
            Console.WriteLine("**************************************");
            //for printing those values 
            Console.WriteLine("the list of item inside my bag are : ");
            int k = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(k + "-" + j[i] + " ");
                if (k == 1)
                {
                    int amount = Convert.ToInt16(j[i]);
                    if (amount < 5000)
                    {
                        Console.WriteLine();
                        j.notTravel();
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        j.travel();
                    }
                }
                k++;
            }

        }
    }
}
