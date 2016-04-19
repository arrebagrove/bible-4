using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bible_2.ViewModels
{
    public class Chapter
    {
        public Chapter()
        {
            Items = new List<Verse>();
        }

        public List<Verse> Items { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
    }
}
