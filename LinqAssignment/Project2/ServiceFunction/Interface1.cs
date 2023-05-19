using Project2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.ServiceFunction
{
    internal interface Interface1
    {
        int CreateBook(Book player);
        IEnumerable<Book> GetBooksList();
        List<Book> GetBooks();
        void Update(int bookNo);
        void Delete(int bookNo);
        void search(int bookNo);
    }
}
