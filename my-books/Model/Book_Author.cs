using System.Collections.Generic;

namespace my_books.Model
{
    public class Book_Author
    {
        public int Id { get; set; }


        public int bookId { get; set; }
        public Book Book { get; set; }

        public int authorId { get; set; }

        public Author Author { get; set; }
    }
}
