using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Bible_2.ViewModels;
using System.Diagnostics;

namespace Bible_2
{
    public partial class ChapterPage : PhoneApplicationPage
    {
        

        public string filepath = "http://labs.bible.org/api/?passage=";

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DataContext == null)
            {
                string selectedBook = "";
                string chapters = "";
                if (NavigationContext.QueryString.TryGetValue("msg", out selectedBook))
                {
                    filepath += selectedBook;
                    Bookname.Text = selectedBook;
                    
                }

            }
        }

        public ChapterPage()
        {
            InitializeComponent();
        }
    }
}