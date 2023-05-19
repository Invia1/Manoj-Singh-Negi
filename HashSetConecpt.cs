using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetConcept
{
    internal class Program
    {
        HashSet<Object> hs = new HashSet<Object>();
        
        public void addItem(Object obj)
        {
            hs.Add(obj);
            Console.WriteLine("added successfully");
            
        }
        public void removeItem(Object obj)
        {
            Console.WriteLine("given value is deleted succefully");
            hs.Remove(obj);
        }
        public void search(Object obj)
        {
           IEnumerable<Object> list = hs;
            foreach (Object item in list)
            {
                if (item.Equals(obj))
                {
                    Console.WriteLine(obj + " is present in the set");
                }
            }
        }
        public HashSet<Object>GetSet()
        {
            return hs;
        }
       
        static void Main(string[] args)
        {
            Program program = new Program();
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("press 1 for adding a element to a set ");
                Console.WriteLine("press 2 for removing a element from a set ");
                Console.WriteLine("press 3 for searching an element");
                Console.WriteLine("press 4 for getting the set");
                Console.WriteLine("enter your choice ");
                int choice=Convert.ToInt32(Console.ReadLine()); 
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter the value");
                        string value= Console.ReadLine();
                        program.addItem(value);
                        break;

                    case 2:
                        Console.WriteLine("enter the value ");
                        string value1=Console.ReadLine();
                        program.removeItem(value1);
                        break;

                    case 3:

                        Console.WriteLine("enter the value ");
                        string value2=Console.ReadLine();
                        program.search(value2);
                        break;

                    case 4:
                        IEnumerable<Object> ienu=program.GetSet();
                        Console.WriteLine("***********************************8");
                        foreach (Object item in ienu)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    default: Console.WriteLine("please enter a valid choice");
                        break;

                }
                Console.WriteLine("do you want to continue press y for yes");
                char ch=Convert.ToChar(Console.ReadLine());
                if(!(ch == 'y') || (ch == 'Y'))
                {
                    flag= false;
                }
                

            }
        }
    }
}
