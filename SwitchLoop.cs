using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static void prime(int n)
        {
            int count = 0;

            if (n == 0 || n == 1)
            {
                Console.WriteLine("not a prime number ");
            }

            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("the number is not a prime number");
            }
            else { Console.WriteLine("the number is a prime number"); }

        }

        public static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }

        public static void fibonacci(int i, int j, int n)
        {
            if (n == 0)
            {
                return;
            }
            int c = i + j;
            Console.WriteLine(c);
            i = j;
            j = c;
            fibonacci(i, j, n - 1);
        }
        public static void mydata()
        {
            int number;
            Console.WriteLine("press 1 for prime");
            Console.WriteLine("press 2 for factorial");
            Console.WriteLine("press 3 for fibonacci");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("please enter your choice from above number : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**********************************************************");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter your number for checking the number is prime or not ");
                    number = Convert.ToInt32(Console.ReadLine());
                    prime(number);
                    break;

                case 2:
                    Console.WriteLine("enter your number whom factorial you want");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(factorial(number));
                    break;

                case 3:
                    Console.WriteLine("enter your number till which you want your fibonacci list");
                    number = Convert.ToInt32(Console.ReadLine());
                    int a = 0;
                    int b = 1;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    fibonacci(a, b, number - 2);
                    break;

                default:
                    Console.WriteLine("please enter a valid choice");
                    break;

            }

        }

        static void Main(string[] args)
        {
            char ch;

            Boolean flag = true;
            while (flag)
            {
                mydata();
                Console.WriteLine("**********************************************************");
                Console.WriteLine("**********************************************************");
                Console.WriteLine("Do you want to continue .Enter Y for yes");
                ch = Convert.ToChar(Console.ReadLine());
                if (ch != 'y' && ch != 'Y')
                    flag = false;
            }


        }
    }
}
