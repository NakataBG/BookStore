using BookStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Interfaces
{
    public interface IAutorRepo
    {
        IEnumerable<Autor> GetAll();
        Autor GetByld(int id);
        void AddAutor(Autor autor);
        void DeleteAutor(int Id);
    }
}
