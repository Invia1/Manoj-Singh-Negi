using System;
using System.Collections;
using ConsoleAppfood.Models;

namespace ConsoleAppfood.BLLayer
{
    internal  class Chef
    {  
        ArrayList list=new ArrayList();
        public ArrayList foodDetails()
        {
            FoodType fd = new FoodType();
            Console.WriteLine("please enter the number of item you have");
            int n = Convert.ToInt16(Console.ReadLine());
            Chef chef = new Chef();

            for (int i=0;i<n;i++ )
            {
                Console.WriteLine("enter the food id :");
                fd.foodId=Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("enter the food Name : ");
                fd.name=Console.ReadLine();

                Console.WriteLine("enter the food Price : ");
                fd.foodPrice=Convert.ToInt16(Console.ReadLine());

                list.Add(fd.foodId);
                list.Add(fd.name);
                list.Add(fd.foodPrice);

            }
            return list; 
        }
    }
}
