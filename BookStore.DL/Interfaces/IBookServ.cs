using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Interfaces
{
   public class IBookServ
    {
        IEnumerable<Book> GetAll();
        Book GetByld(int id);
        void AddBook(Book book);
        void DeleteBook(int Id);
    }
}
