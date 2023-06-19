using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookStore.Models.Data;

namespace BookStore.Models.Responses
{
    public class GetAllBooksByAuthorResponse
    {
        public Autor Autor { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }
}
