using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_check_2
{
    public class Media
    {
        public string Title { get; set; }
        public string Genre { get; set; }

    }

    public class Book : Media
    {
        public string Author { get; set; }
        public int Pages { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Title, Genre, Author, Pages);
        }

    }
}
