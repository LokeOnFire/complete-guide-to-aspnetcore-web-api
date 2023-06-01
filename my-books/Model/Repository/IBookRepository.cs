using System.Collections.Generic;

namespace my_books.Model.Repository
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
        Book Get(int id);
        List<Book> GetAll(int? pageNumber);
    }
}
