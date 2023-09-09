using lab9.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.Model
{
    public class BookRepository : IRepository<Book>
    {
        private Model1 db;
        public BookRepository(Model1 db)
        {
            this.db = db;
        }
        public void Create(Book book)
        {
            db.Book.Add(book);
        }

        public void Delete(int id)
        {
            Book book = db.Book.Find(id);
            if (book != null)
            {
                db.Book.Remove(book);
            }
        }

        public Book Get(int id)
        {
            return db.Book.Find(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return db.Book;
        }

        public void Update(Book book)
        {
            db.Entry(book).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
