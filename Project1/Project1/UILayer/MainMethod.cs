using Project1.Models;
using Project1.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Project1.UILayer
{
    internal class MainMethod
    {
        public static void Main(string[] args)
        {
            int id;
            StudentDetails studentDetails = new StudentDetails();
            Boolean flag = true;
            
            while(flag)
            {
                Console.WriteLine("press 1 for adding new student");
                Console.WriteLine("press 2 for viewing the list ");
                Console.WriteLine("press 3 for update");
                Console.WriteLine("press 4 for delete");
                Console.WriteLine("press 5 for search");

                Console.WriteLine("enter your choice :");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Student student = new Student();
                        Console.WriteLine("enter student Id : ");
                        student.Id=Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter student Name : ");
                        student.Name=Console.ReadLine();

                        Console.WriteLine("enter the student address");
                        student.address=Console.ReadLine(); 
                        studentDetails.CreateStudent(student);
                        //student.Equals(null);
                        break;
                    case 2:
                        Console.WriteLine("your data in the list is : ");
                        List<Student> studentList = studentDetails.GetList();
                        foreach (var items in studentList)
                        {
                            Console.WriteLine(items.Id + " " + items.Name + " " + items.address);
                        }
                        break;

                    case 3:
                        Console.WriteLine("to update the element enter the id");
                         id = Convert.ToInt32(Console.ReadLine());
                        studentDetails.Update(id);
                        break;

                    case 4:
                        Console.WriteLine("to delete the element enter the id");
                         id = Convert.ToInt32(Console.ReadLine());
                        studentDetails.Delete(id);
                        break;

                    case 5:
                        Console.WriteLine("to search a element. enter the id");
                        id = Convert.ToInt32(Console.ReadLine());
                        studentDetails.search(id);
                        break;

                    default:
                        Console.WriteLine("please enter a valid");
                        break;

                }
                Console.WriteLine("do you want to continue , if yes the press y");
                char ch=Convert.ToChar(Console.ReadLine());
                if(!(ch=='y'||ch=='Y'))
                {
                    flag= false;
                }

            }
            
        }
    }
}
