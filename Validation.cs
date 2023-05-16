using System;

namespace ConsoleApp5
{
    internal class AmountDetails
    {
        int amount;
        string name;

        Shoping s = new Shoping();
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public int Amount
        {
            get { return amount; }
            set
            {
                amount = value;

                if (amount >= 10000)
                {
                    Console.Write("hello " + name);
                    s.doShoping();
                }
                else
                {
                    Console.Write("hello " + name);
                    s.canNotDoShoping();
                    Console.Write(" because you have only " + amount + " rupees but for doing shopping you should have atleast 10,000 ");
                    Console.WriteLine();
                }
            }
        }
    }

    internal class Shoping
    {
        AmountDetails obj = new AmountDetails();

        public void doShoping()
        {
            Console.WriteLine(" you could do shoping");
        }
        public void canNotDoShoping()
        {
            Console.WriteLine(" you can not do shoping ,because you dont have enough money for shopping");
        }
        public void notNull()
        {
            Console.WriteLine("value can't be null");
        }
        public void show()
        {
            
            Shoping s = new Shoping();
            Boolean flag = true;
            Console.WriteLine("please enter you name");
            while (flag)
            {
                string name = Console.ReadLine();
                if (name == "")
                {
                    s.notNull();
                    Console.WriteLine("please enter a name");
                }
                else
                {
                    obj.Name = name;
                    flag = false;
                }
            }
        }
        public void show1()
        {
           
            Boolean flag = true;
            Console.WriteLine("please enter the amout : ");
            while (flag)
            {
                try
                {
                    int n = Convert.ToInt16(Console.ReadLine());
                    obj.Amount = n;
                    flag = false;
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("please enter a valid");
                    Console.WriteLine("please enter the amount");
                }
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Shoping s = new Shoping();
            s.show();
            s.show1();
        }
    }
}
