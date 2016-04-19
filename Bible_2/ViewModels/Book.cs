using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bible_2.ViewModels
{
    public class Book
    {
        public Book()
        {
            Items = new List<Chapter>();
        }

        public List<Chapter> Items { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
        public string chno { get; set; }
        public string icon { get; set; }
    }
}
