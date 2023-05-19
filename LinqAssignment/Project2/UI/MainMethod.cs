using System;
using Project2.Model;
using System.Collections.Generic;
using Project2.ServiceFunction;
using Project2.Service;

namespace Project2.UI
{
    internal class MainMethod
    {
        public static void Main(string[] args)
        { 
            int bookno;
            Interface1 inter = new BookDetails();
            Boolean flag = true;

            while (flag)
            {
                Console.WriteLine("press 1 for adding new Book");
                Console.WriteLine("press 2 for viewing the list of books  ");
                Console.WriteLine("press 3 for update");
                Console.WriteLine("press 4 for delete");
                Console.WriteLine("press 5 for search");

                Console.WriteLine("enter your choice :");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Book book = new Book();
                        Console.WriteLine("enter Book No : ");
                        book.BookNo= Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter Book Name : ");
                        book.Name = Console.ReadLine();

                        Console.WriteLine("enter Book Auther ");
                        book.auther = Console.ReadLine();

                        

                        inter.CreateBook(book);
                        break;
                    case 2:
                        Console.WriteLine("************************************");
                        Console.WriteLine("your data in the list are: ");
                        IEnumerable<Book> bookList = inter.GetBooksList();
                       
                        Console.WriteLine("-------------------------------");
                        foreach (var items in bookList)
                        {
                            Console.WriteLine("Book number        :"+items.BookNo);
                            Console.WriteLine("Book Name          :"+items.Name);
                            Console.WriteLine("Book Auther Name   :"+items.auther);
                           
                            Console.WriteLine("*************************************");
                        }
                        break;

                    case 3:
                        Console.WriteLine("to update the book .please enter the book number ");
                        bookno = Convert.ToInt32(Console.ReadLine());
                        inter.Update(bookno);
                        break;

                    case 4:
                        Console.WriteLine("to delete a book enter the book number");
                        bookno = Convert.ToInt32(Console.ReadLine());
                        inter.Delete(bookno);
                        break;

                    case 5:
                        Console.WriteLine("to search a Book. enter the Book number");
                        bookno = Convert.ToInt32(Console.ReadLine());
                        inter.search(bookno);
                        break;

                    default:
                        Console.WriteLine("please enter a valid");
                        break;
                }
                Console.WriteLine("do you want to continue , if yes the press y");
                char ch = Convert.ToChar(Console.ReadLine());
                if (!(ch == 'y' || ch == 'Y'))
                {
                    flag = false;
                }
            }
        }
    }
}
