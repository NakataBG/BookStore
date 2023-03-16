using BookStore.BL.Interfaces;
using BookStore.DL.Repositori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class BookServ:IBookServ
    {
        private readonly IBookRepo _bookRepo;

        public BookServ(IBookRepo bookRepo)
        {
            _bookRepo = bookRepo;
        }

        public void AddBook(Book book)
        {
            _bookRepo.AddBook(book);
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepo.GetAll();
        }

        public Book GetById(int id)
        {
            return _bookRepo.GetByld(id);
        }

        public void DeleteBook(int id)
        {
            _bookRepo.DeleteBook(id);
        }
    }
}
