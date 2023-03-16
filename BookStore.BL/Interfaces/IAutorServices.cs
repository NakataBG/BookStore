using BookStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interfaces
{
    public interface IAutorServices
    {
        IEnumerable<Autor> GetAll();

        Autor GetById(int id);
        void AddAutor(Autor autor);
        void RemoveAutor(Autor autor);
        void DeleteAutor(int autorId);
    }
}
