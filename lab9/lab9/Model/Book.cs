using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.Model
{
    public class Book
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public List<Author> Authors { get; set; }
    }
}
