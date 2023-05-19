using Project2.Model;
using Project2.ServiceFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Service
{
    internal class BookDetails:Interface1
    {
        List<Book> list = new List<Book>();
        public int CreateBook(Book book)
        {
            List<Book> list1 = GetBooks();
            int count = 0;
            foreach (Book book1 in list1)
            {
                if(book1.BookNo==book.BookNo)
                {
                    count++;
                    Console.WriteLine("Book number "+book.BookNo+" is already present");
                    break;
                }
            }
            if (count == 0)
            {
                list1.Add(book);
            }
            return 1;
        }
        //for just traversing
        public IEnumerable<Book> GetBooksList()
        {
            return list;
        }

        public List<Book> GetBooks()
        {
            return list;
        }

        //for update 
        public void Update(int bookNo)
        {
            List<Book> books = GetBooks();
            if(books.Count==0)
            {
                Console.WriteLine("list is empty");
            }
            try
            {
                foreach (var BOOK in books.Where(b => b.BookNo == bookNo))
                {
                    if (BOOK.BookNo==bookNo)
                    {
                       BOOK.BookNo = bookNo;
                        Console.WriteLine("enter the new name");
                        BOOK.Name = Console.ReadLine();

                        Console.WriteLine("enter the auther name");
                        BOOK.auther = Console.ReadLine();

                        Console.WriteLine("your data is updated successfully");
                    }
                }
            }
            catch (Exception ex) { ex.ToString(); }
        }
        //delete the object
        public void Delete(int bookno)
        {
            List<Book> books = GetBooks();
            if (books.Count==0)
            {
                Console.WriteLine("list is empty");
            }
            try
            {
                foreach (var BOOK in books.Where(b => b.BookNo == bookno))
                {
                    if (BOOK.BookNo==bookno)
                    {
                        Console.WriteLine("the data of book no " + bookno + " is deleted successfully");
                       books.Remove(BOOK);
                    }
                }
            }
            catch (Exception ex) { ex.ToString(); }
        }
        //for searching a perticular object
        public void search(int bookno)
        {

            IEnumerable<Book> books = GetBooksList();
            try
            {
                foreach (var BOOK in books.Where(b => b.BookNo == bookno))
                {
                    if (BOOK.BookNo==bookno)
                    {
                        Console.WriteLine("name     :" + BOOK.Name);
                        Console.WriteLine("position :" + BOOK.auther);
                        break;
                    }
                }
            }
            catch (Exception ex) { ex.ToString(); }
        }

    }
}
