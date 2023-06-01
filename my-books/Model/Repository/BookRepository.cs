using my_books.Model.Pagination;
using System.Collections.Generic;
using System.Linq;

namespace my_books.Model.Repository
{
    public class BookRepository : IBookRepository
    {
        private AppDBContext _context;

        public BookRepository(AppDBContext context)
        {
            _context = context;
        }
        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(Book book)
        {
            
            _context.Remove(book);
            _context.SaveChanges();
        }

        public Book Get(int id)
        {
            return _context.Books.FirstOrDefault(x => x.Id == id);
        }

        public List<Book> GetAll(int? pageNumber)
        {
            var allBooks = _context.Books.ToList();
            int pagesize = 3;
             allBooks =  PaginatedList<Book>.Create(allBooks.AsQueryable(),pageNumber ?? 1, pagesize);


            return allBooks;
        }

        public void Update(Book book)
        {
            throw new System.NotImplementedException();
         
        }
    }
}
