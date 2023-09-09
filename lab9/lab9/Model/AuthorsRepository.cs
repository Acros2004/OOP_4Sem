using lab9.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.Model
{
    public class AuthorsRepository : IRepository<Author>
    {
        private Model1 db;

        public AuthorsRepository(Model1 db)
        {
            this.db = db;
        }
        public IEnumerable<Author> GetAll()
        {
            return db.Author;
        }
        public Author Get(int id)
        {
            return db.Author.Find(id);
        }
        public void Create(Author author)
        {
            db.Author.Add(author);
        }
        public void Update(Author author)
        {
            db.Entry(author).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            Author author = db.Author.Find(id);
            if(author != null)
            {
                db.Author.Remove(author);
            }
        }
    }
}
