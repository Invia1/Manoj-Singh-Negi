using ConsoleAppfood.BLLayer;
using System;
using System.Collections;
using ConsoleAppfood.Models;

namespace ConsoleAppfood.EntryPoint
{
    internal class Customer
    {
       public static void Main(string[] args)
        {
            Chef chef = new Chef();
            ArrayList list = new ArrayList();
            list = chef.foodDetails();
            Console.WriteLine("list of item ");
           foreach (var i in list) {
                Console.WriteLine("**************************");
                Console.WriteLine(i);
               
            }
        }
    }
}
