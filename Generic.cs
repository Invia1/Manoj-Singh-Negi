﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class TypeGeneric
    {

        public void AddData<T>(ArrayList list)
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("enter the name you want to add in the list : ");
                string name = Console.ReadLine();
                list.Add(name);
                Console.WriteLine("do you want to add more element if yes then press y");
                char ch = Convert.ToChar(Console.ReadLine());
                if (!(ch == 'Y' || ch == 'y'))
                {
                    flag = false;
                }
            }
        }
        public void RemoveData<T>(ArrayList list)
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("enter the name you want to remove :");
                string name = Console.ReadLine();
                if (list.Count == 0)
                {
                    Console.WriteLine("list is empty");
                }
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Equals(name))
                    {
                        list.Remove(name);
                        Console.WriteLine(name + " is removed from the list ");
                    }
                }
                Console.WriteLine("do you want to remove more element if yes the press y :");
                char ch = Convert.ToChar(Console.ReadLine());
                if (!(ch == 'Y' || ch == 'y'))
                {
                    flag = false;
                }
            }
        }

        public void Search<T>(ArrayList list)
        {
            Console.WriteLine("enter the value ,you want to search : ");
            string name = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(name))
                {

                    Console.WriteLine(name + " is present in the list at " + i + 1 + " position");

                }
            }
        }
        public void update<T>(ArrayList list)
        {
            Console.WriteLine("enter the new name : ");
            string name = Console.ReadLine();

            Console.WriteLine("enter the name ,who you want to replace");
            string oldName = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(oldName))
                {
                    list[i] = name;
                    Console.WriteLine("the given name " + name + " is upadated successfully");
                    break;
                }
            }
        }
        public void ShowList<T>(ArrayList list)
        {
            if (list.Count == 0)
            { Console.WriteLine("list is empty"); }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Boolean flag = true;

            while (flag)
            {
                Console.WriteLine("****************hello , welcome to this page ***************** ");
                Console.WriteLine("press 1 for adding a new item in the list");
                Console.WriteLine("press 2 for deleting a element from the list ");
                Console.WriteLine("press 3 for searching an element in the list ");
                Console.WriteLine("press 4 for upadating an element in the list ");
                Console.WriteLine("press 5 to view all the  element in the list ");
                TypeGeneric f = new TypeGeneric();
                Console.WriteLine("enter your choice : ");
                try
                {
                    int choice = Convert.ToInt16(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            f.AddData<string>(list); break;

                        case 2:
                            f.RemoveData<string>(list); break;


                        case 3:
                            f.Search<string>(list); break;

                        case 4:
                            f.update<string>(list); break;

                        case 5: f.ShowList<string>(list); break;

                        default:
                            Console.WriteLine("please enter a valid choice ");
                            break;
                    }
                }
                catch (Exception) { Console.WriteLine("Enter a valid choice"); }
            }
            Console.WriteLine("do you want to continue.. if yes the press Y ");
            char ch = Convert.ToChar(Console.ReadLine());
            if (!(ch == 'y' || ch == 'Y'))
            {
                flag = false;
            }
        }

    }
}

