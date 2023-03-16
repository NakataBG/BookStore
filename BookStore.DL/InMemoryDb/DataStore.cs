using BookStore.Models.Data;

namespace BookStore.DL.InMemoryDb
{
    public  static class DataStore
    {
        public static List<Autor> Books
            = new List<Autor>()
            {
                new Autor()
                {
                    Id= 1,
                    Name="Gosho",
                    Bio = "Gosho bio"

                },
                new Autor()
                {
                    Id= 2,
                    Name="Ginka",
                    Bio = "Ginka bio"

                }

            };

        
    }
}
