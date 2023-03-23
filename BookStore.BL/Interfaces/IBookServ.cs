using BookStore.DL.Interfaces;
using BookStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interfaces
{
    public class IBookServ
    {
        IEnumerable<Book> GetAll();

        Book GetById(int id);

        void Add(AddBookRequest author);

        void Delete(int id);
    }
}
