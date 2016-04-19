using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bible_2.ViewModels
{
    public class Testament
    {
        public Testament()
        {
            Items = new List<Book>();
        }

        public List<Book> Items { get; set; }
        public int count { get; set; }
        public string Title { get; set; }
    }
}
