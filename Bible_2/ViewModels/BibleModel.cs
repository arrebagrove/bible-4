using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bible_2.ViewModels
{
    public class BibleModel
    {
        public Testament OldT { get; set; }
        public Testament NewT { get; set; }
        

        public bool IsDataLoaded { get; set; }

        

        public void LoadData()
        {
            OldT = CreateOldTestament();
            NewT = CreateNewTestament();
            IsDataLoaded = true;
        }

        private Testament CreateOldTestament()
        {
            Testament data = new Testament();
            data.count = 46;
            data.Title = "Old Testament";
            String basePath = "http://labs.bible.org/api/?passage=";

            data.Items.Add(new Book
            {
                Title = "Genesis",
                FilePath = basePath + "Genesis",
                chno = "50",
                icon="/Assets/icons/gen.png"
            });

            data.Items.Add(new Book
            {
                Title = "Exodus",
                FilePath = basePath + "Exodus",
                chno = "40",
                icon = "/Assets/icons/ex.png" 
            });

            data.Items.Add(new Book
            {
                Title = "Leviticus",
                FilePath = basePath + "Leviticus",
                chno = "27",
                icon = "/Assets/icons/lev.png"
            });

            data.Items.Add(new Book
            {
                Title = "Numbers",
                FilePath = basePath + "Numbers",
                chno = "36",
                icon = "/Assets/icons/nm.png"
            });

            data.Items.Add(new Book
            {
                Title = "Deuteronomy",
                FilePath = basePath + "Deuteronomy",
                chno = "34",
                icon = "/Assets/icons/dt.png"
            });

            data.Items.Add(new Book
            {
                Title = "Joshua",
                FilePath = basePath + "Joshua",
                chno = "24",
                icon = "/Assets/icons/jo.png"
            });

            data.Items.Add(new Book
            {
                Title = "Judges",
                FilePath = basePath + "Judges",
                chno = "21",
                icon = "/Assets/icons/jgs.png"

            });

            data.Items.Add(new Book
            {
                Title = "Ruth",
                FilePath = basePath + "Ruth",
                chno = "4",
                icon = "/Assets/icons/ru.png"
            });

            data.Items.Add(new Book
            {
                Title = "1 Samuel",
                FilePath = basePath + "1 Samuel",
                chno = "31",
                icon = "/Assets/icons/1sam.png"
            });

            data.Items.Add(new Book
            {
                Title = "2 Samuel",
                FilePath = basePath + "2 Samuel",
                chno = "24",
                icon = "/Assets/icons/2sam.png"
            });

            data.Items.Add(new Book
            {
                Title = "1 Kings",
                FilePath = basePath + "1 Kings",
                chno = "22",
                icon = "/Assets/icons/1kgs.png"
            });

            data.Items.Add(new Book
            {
                Title = "2 Kings",
                FilePath = basePath + "2 Kings",
                chno = "25",
                icon = "/Assets/icons/2kgs.png"
            });


            data.Items.Add(new Book
            {
                Title = "1 Chronicles",
                FilePath = basePath + "1 Chronicles",
                chno = "29",
                icon = "/Assets/icons/1chr.png"
            });

            data.Items.Add(new Book
            {
                Title = "2 Chronicles",
                FilePath = basePath + "2 Chronicles",
                chno = "36",
                icon = "/Assets/icons/2chr.png"
            });

            data.Items.Add(new Book
            {
                Title = "Ezra",
                FilePath = basePath + "Ezra",
                chno = "10",
                icon = "/Assets/icons/ezr.png"
            });

            data.Items.Add(new Book
            {
                Title = "Nehemiah",
                FilePath = basePath + "Nehemiah",
                chno = "13",
                icon = "/Assets/icons/neh.png"
            });

            data.Items.Add(new Book
            {
                Title = "Tobit",
                FilePath = basePath + "Tobit",
                chno = "14",
                icon = "/Assets/icons/tb.png"
            });

           /* data.Items.Add(new Book
            {
                Title = "Judith",
                FilePath = basePath + "Judith",
                chno = "16",
                icon = "/Assets/icons/jdt.png"
            });
            */
            data.Items.Add(new Book
            {
                Title = "Esther",
                FilePath = basePath + "Esther",
                chno = "10",
                icon = "/Assets/icons/est.png"
            });

            data.Items.Add(new Book
            {
                Title = "1 Maccabees",
                FilePath = basePath + "1 Maccabees",
                chno = "16",
                icon = "/Assets/icons/1mc.png"
            });

            data.Items.Add(new Book
            {
                Title = "2 Maccabees",
                FilePath = basePath + "2 Maccabees",
                chno = "15",
                icon = "/Assets/icons/2mc.png"
            });

            data.Items.Add(new Book
            {
                Title = "Job",
                FilePath = basePath + "Job",
                chno = "42",
                icon = "/Assets/icons/jb.png"
            });

            data.Items.Add(new Book
            {
                Title = "Psalm",
                FilePath = basePath + "Psalm",
                chno = "150",
                icon = "/Assets/icons/ps.png"
            });

            data.Items.Add(new Book
            {
                Title = "Proverbs",
                FilePath = basePath + "Proverbs",
                chno = "31",
                icon = "/Assets/icons/prv.png"
            });

            data.Items.Add(new Book
            {
                Title = "Ecclesiastes",
                FilePath = basePath + "Ecclesiastes",
                chno = "12",
                icon = "/Assets/icons/eccl.png"
            });

            data.Items.Add(new Book
            {
                Title = "Song of Solomon",
                FilePath = basePath + "Song of Solomon",
                chno = "8",
                icon = "/Assets/icons/sg.png"
            });

            data.Items.Add(new Book
            {
                Title = "Wisdom",
                FilePath = basePath + "Wisdom",
                chno = "19",
                icon = "/Assets/icons/ws.png"
            });

            data.Items.Add(new Book
            {
                Title = "Sirach",
                FilePath = basePath + "Sirach",
                chno = "51",
                icon = "/Assets/icons/sir.png"
            });

            data.Items.Add(new Book
            {
                Title = "Isaiah",
                FilePath = basePath + "Isaiah",
                chno = "66",
                icon = "/Assets/icons/is.png"
            });

            data.Items.Add(new Book
            {
                Title = "Jeremiah",
                FilePath = basePath + "Jeremiah",
                chno = "52",
                icon = "/Assets/icons/jer.png"
            });

            data.Items.Add(new Book
            {
                Title = "Lamentations",
                FilePath = basePath + "Lamentations",
                chno = "5",
                icon = "/Assets/icons/lam.png"
            });

            data.Items.Add(new Book
            {
                Title = "Baruch",
                FilePath = basePath + "Baruch",
                chno = "5",
                icon = "/Assets/icons/bar.png"
            });

            data.Items.Add(new Book
            {
                Title = "Ezekiel",
                FilePath = basePath + "Ezekiel",
                chno = "48",
                icon = "/Assets/icons/ez.png"
            });

            data.Items.Add(new Book
            {
                Title = "Daniel",
                FilePath = basePath + "Daniel",
                chno = "12",
                icon = "/Assets/icons/dn.png"
            });

            data.Items.Add(new Book
            {
                Title = "Hosea",
                FilePath = basePath + "Hosea",
                chno = "14",
                icon = "/Assets/icons/hos.png"
            });

            data.Items.Add(new Book
            {
                Title = "Joel",
                FilePath = basePath + "Joel",
                chno = "3",
                icon = "/Assets/icons/jl.png"
            });

            data.Items.Add(new Book
            {
                Title = "Amos",
                FilePath = basePath + "Amos",
                chno = "9",
                icon = "/Assets/icons/am.png"
            });

            data.Items.Add(new Book
            {
                Title = "Obadiah",
                FilePath = basePath + "Obadiah",
                chno = "1",
                icon = "/Assets/icons/ob.png"
            });

            data.Items.Add(new Book
            {
                Title = "Jonah",
                FilePath = basePath + "Jonah",
                chno = "4",
                icon = "/Assets/icons/jo.png"
            });

            data.Items.Add(new Book
            {
                Title = "Micah",
                FilePath = basePath + "Micah",
                chno = "7",
                icon = "/Assets/icons/mi.png"
            });

            data.Items.Add(new Book
            {
                Title = "Nahum",
                FilePath = basePath + "Nahum",
                chno = "3",
                icon = "/Assets/icons/na.png"
            });

            data.Items.Add(new Book
            {
                Title = "Habakkuk",
                FilePath = basePath + "Habakkuk",
                chno = "3",
                icon = "/Assets/icons/hb.png"
            });

            data.Items.Add(new Book
            {
                Title = "Zephaniah",
                FilePath = basePath + "Zephaniah",
                chno = "3",
                icon = "/Assets/icons/zep.png"
            });

            data.Items.Add(new Book
            {
                Title = "Haggai",
                FilePath = basePath + "Haggai",
                chno = "2",
                icon = "/Assets/icons/hg.png"
            });

            data.Items.Add(new Book
            {
                Title = "Zechariah",
                FilePath = basePath + "Zechariah",
                chno = "14",
                icon = "/Assets/icons/zec.png"
            });

            data.Items.Add(new Book
            {
                Title = "Malachi",
                FilePath = basePath + "Malachi",
                chno = "4",
                icon = "/Assets/icons/mal.png"
            });

            return data;
        }

        private Testament CreateNewTestament()
        {
            Testament data = new Testament();
            data.count = 27;
            data.Title = "New Testament";
            String basePath = "http://labs.bible.org/api/?passage=";

            data.Items.Add(new Book
            {
                Title = "Matthew",
                FilePath = basePath + "Matthew",
                chno = "28",
                icon = "/Assets/icons/mt.png"

            });

            data.Items.Add(new Book
            {
                Title = "Mark",
                FilePath = basePath + "Mark",
                chno = "16",
                icon = "/Assets/icons/mk.png"
            });

            data.Items.Add(new Book
            {
                Title = "Luke",
                FilePath = basePath + "Luke",
                chno = "24",
                icon = "/Assets/icons/lk.png"
            });

            data.Items.Add(new Book
            {
                Title = "John",
                FilePath = basePath + "John",
                chno = "21",
                icon = "/Assets/icons/jn.png"
            });

            data.Items.Add(new Book
            {
                Title = "Acts",
                FilePath = basePath + "Acts",
                chno = "28",
                icon = "/Assets/icons/acts.png"
            });

            data.Items.Add(new Book
            {
                Title = "Romans",
                FilePath = basePath + "Romans",
                chno = "16",
                icon = "/Assets/icons/rom.png"
            });

            data.Items.Add(new Book
            {
                Title = "1 Corinthians",
                FilePath = basePath + "1 Corinthians",
                chno = "16",
                icon = "/Assets/icons/1cor.png"

            });

            data.Items.Add(new Book
            {
                Title = "2 Corinthians",
                FilePath = basePath + "2 Corinthians",
                chno = "13",
                icon = "/Assets/icons/2cor.png"
            });

            data.Items.Add(new Book
            {
                Title = "Galatians",
                FilePath = basePath + "Galatians",
                chno = "6",
                icon = "/Assets/icons/gal.png"
            });

            data.Items.Add(new Book
            {
                Title = "Ephesians",
                FilePath = basePath + "Ephesians",
                chno = "6",
                icon = "/Assets/icons/eph.png"
            });

            data.Items.Add(new Book
            {
                Title = "Philippians",
                FilePath = basePath + "Philippians",
                chno = "4",
                icon = "/Assets/icons/phil.png"
            });

            data.Items.Add(new Book
            {
                Title = "Colossians",
                FilePath = basePath + "Colossians",
                chno = "4",
                icon = "/Assets/icons/col.png"
            });


            data.Items.Add(new Book
            {
                Title = "1 Thessalonians",
                FilePath = basePath + "1 Thessalonians",
                chno = "5",
                icon = "/Assets/icons/1thes.png"
            });

            data.Items.Add(new Book
            {
                Title = "2 Thessalonians",
                FilePath = basePath + "2 Thessalonians",
                chno = "3",
                icon = "/Assets/icons/2thes.png"
            });

            data.Items.Add(new Book
            {
                Title = "1 Timothy",
                FilePath = basePath + "1 Timothy",
                chno = "6",
                icon = "/Assets/icons/1tim.png"
            });

            data.Items.Add(new Book
            {
                Title = "2 Timothy",
                FilePath = basePath + "2 Timothy",
                chno = "4",
                icon = "/Assets/icons/2tim.png"
            });

            data.Items.Add(new Book
            {
                Title = "Titus",
                FilePath = basePath + "Titus",
                chno = "3",
                icon = "/Assets/icons/ti.png"
            });

            data.Items.Add(new Book
            {
                Title = "Philemon",
                FilePath = basePath + "Philemon",
                chno = "1",
                icon = "/Assets/icons/phlm.png"
            });

            data.Items.Add(new Book
            {
                Title = "Hebrews",
                FilePath = basePath + "Hebrews",
                chno = "13",
                icon = "/Assets/icons/heb.png"
            });

            data.Items.Add(new Book
            {
                Title = "James",
                FilePath = basePath + "James",
                chno = "5",
                icon = "/Assets/icons/jas.png"
            });

            data.Items.Add(new Book
            {
                Title = "1 Peter",
                FilePath = basePath + "1 Peter",
                chno = "5",
                icon = "/Assets/icons/1pt.png"
            });

            data.Items.Add(new Book
            {
                Title = "2 Peter",
                FilePath = basePath + "2 Peter",
                chno = "3",
                icon = "/Assets/icons/2pt.png"
            });

            data.Items.Add(new Book
            {
                Title = "1 John",
                FilePath = basePath + "1 John",
                chno = "5",
                icon = "/Assets/icons/1jn.png"
            });

            data.Items.Add(new Book
            {
                Title = "2 John",
                FilePath = basePath + "2 John",
                chno = "1",
                icon = "/Assets/icons/2jn.png"
            });

            data.Items.Add(new Book
            {
                Title = "3 John",
                FilePath = basePath + "3 John",
                chno = "1",
                icon = "/Assets/icons/3jn.png"
            });

            data.Items.Add(new Book
            {
                Title = "Jude",
                FilePath = basePath + "Jude",
                chno = "1",
                icon = "/Assets/icons/jude.png"
            });

            data.Items.Add(new Book
            {
                Title = "Revelation",
                FilePath = basePath + "Revelation",
                chno = "22",
                icon = "/Assets/icons/rev.png"
            });

            return data;
        }
    }
}
