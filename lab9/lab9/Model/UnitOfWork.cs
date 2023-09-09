using lab9.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.Model
{
    public class UnitOfWork
    {
        private Model1 db = new Model1();
        private AuthorsRepository authorRepository;
        private BookRepository bookRepository;
        private bool disposed = false;

        public AuthorsRepository Authors
        {
            get
            {
                if(authorRepository == null)
                    authorRepository = new AuthorsRepository(db);
                return authorRepository;
            }
        }
        public BookRepository Books
        {
            get
            {
                if (bookRepository == null)
                    bookRepository = new BookRepository(db);
                return bookRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
