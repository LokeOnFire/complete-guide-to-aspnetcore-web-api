using System.Collections.Generic;

namespace my_books.Model
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation
        public List<Book> books { get; set; }
    }
}
