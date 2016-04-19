using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Diagnostics;

namespace Bible_2
{
    public partial class Read : PhoneApplicationPage
    {
        public Read()
        {
            InitializeComponent();
        }

        public string filepath = "http://labs.bible.org/api/?passage=";

        public int c = 1;
        //if(NavigationContext.QueryString.TryGetValue("ch", out aaa))
        public int ch =0;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DataContext == null)
            {
                string selectedBook = "";
                string aaa = "";
                if (NavigationContext.QueryString.TryGetValue("ch", out aaa))
                {
                    //Debug.WriteLine(aaa);
                    ch = int.Parse(aaa);
                }

                if (NavigationContext.QueryString.TryGetValue("msg", out selectedBook))
                {
                    if (selectedBook == "votd")
                    {
                        filepath += selectedBook;
                        Bookname.Text = "Verse of the Day";
                        sd.Source = new Uri(filepath, UriKind.Absolute);
                        Next.Visibility = Visibility.Collapsed;
                        Prev.Visibility = Visibility.Collapsed;
                    }

                    else if (selectedBook == "random")
                    {
                        filepath += selectedBook;
                        Bookname.Text = "Random Verse";
                        sd.Source = new Uri(filepath, UriKind.Absolute);
                        Next.Visibility = Visibility.Collapsed;
                        Prev.Visibility = Visibility.Collapsed;
                    }

                    else
                    {
                        //c++;
                        filepath += selectedBook;
                        Bookname.Text = selectedBook;
                        //Debug.WriteLine(filepath);
                        sd.Source = new Uri(filepath + " " + c, UriKind.Absolute);
                        //Debug.WriteLine(filepath);
                        if (c == 1)
                            Prev.IsEnabled = false;
                        if (c == ch)
                            Next.IsEnabled = false;
                        //sd.Background = new SystemColors("Transparent");
                    }
                }

            }
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            if (c != 0)
            {
                c--;
                if (c == 1)
                    Prev.IsEnabled = false;
                if (c == ch)
                    Next.IsEnabled = false;

                sd.Source = new Uri(filepath +" " + c, UriKind.Absolute);


            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (c < ch)
            {
                c++;
                sd.Source = new Uri(filepath + " " + c, UriKind.Absolute);
            }

            if (c == ch)
                Next.IsEnabled = false;

            if (c >= 1 && c <= ch)
                Prev.IsEnabled = true;
        }
    }
}