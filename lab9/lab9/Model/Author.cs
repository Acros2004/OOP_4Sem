using lab9.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace lab9.Model
{
    public class Author
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int bookID { get; set; }

        public static async Task addAuthor(Author author)
        {
            Model1 db = new Model1();
            try
            {
                db.Author.Add(author);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetNameById(int id)
        {
            Model1 db = new Model1();
            var result = db.Author.Where(p => p.id == id);
            StringBuilder str = new StringBuilder();
            foreach (Author item in result)
            {
                str.Append(item.name + "\r\n");
            }
            MessageBox.Show(str.ToString());
        }
    }

    
}
