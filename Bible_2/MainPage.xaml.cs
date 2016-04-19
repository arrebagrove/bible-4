using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Bible_2.ViewModels;
using System.Diagnostics;
using Coding4Fun.Toolkit.Controls;
using RateMyApp.Controls;
using RateMyApp.Helpers;

namespace Bible_2
{
    public partial class MainPage : PhoneApplicationPage
    {
        public Book b { get; set; }
        public string filepath = "http://labs.bible.org/api/?passage=";
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            BuildApplicationBar();
            FeedbackOverlay.VisibilityChanged += FeedbackOverlay_VisibilityChanged;
        }

        private void BuildApplicationBar()
        {
            //throw new NotImplementedException();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void ChapterTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
           /* if (OldSelector.SelectedItem == null)
                return;


            NavigationService.Navigate(new Uri("/ChapterPage.xaml?msg=" + (OldSelector.SelectedItem as Book).Title + "&ch=" + (OldSelector.SelectedItem as Book).chno, UriKind.Relative));
            * */
        }

        private void ReadTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
           // NavigationService.Navigate(new Uri("/Read.xaml?msg=" + (OldSelector.SelectedItem as Book).Title + "&ch=" + (OldSelector.SelectedItem as Book).chno, UriKind.Relative));
        }

        private void OldSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OldSelector.SelectedItem == null)
                return;

      /*      b = new Book();
            filepath = "http://labs.bible.org/api/?passage=" + (OldSelector.SelectedItem as Book).Title;
            for (int i = 1; i <= int.Parse((OldSelector.SelectedItem as Book).chno) ; i++)
            {

                b.Items.Add(new Chapter
                {
                    Title = i + "",
                    FilePath = filepath + " " + i

                });
                //Debug.WriteLine("Entered " + i + filepath);
                //Debug.WriteLine(b.Items[i-1].Title);
            }
            */
            //NavigationService.Navigate(new Uri("/ChapterPage.xaml?msg=" + (OldSelector.SelectedItem as Book).Title + "&ch=" + (OldSelector.SelectedItem as Book).chno, UriKind.Relative));
            NavigationService.Navigate(new Uri("/Read.xaml?msg=" + (OldSelector.SelectedItem as Book).Title + "&ch=" + (OldSelector.SelectedItem as Book).chno, UriKind.Relative));
        }

        private void NewSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NewSelector.SelectedItem == null)
                return;

  //          b = new Book();
//            filepath = "http://labs.bible.org/api/?passage=" + (NewSelector.SelectedItem as Book).Title;

           // NavigationService.Navigate(new Uri("/ChapterPage.xaml?msg=" + (NewSelector.SelectedItem as Book).Title + "&ch=" + (NewSelector.SelectedItem as Book).chno, UriKind.Relative));
            NavigationService.Navigate(new Uri("/Read.xaml?msg=" + (NewSelector.SelectedItem as Book).Title + "&ch=" + (NewSelector.SelectedItem as Book).chno, UriKind.Relative));
        }

        private void nReadTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/Read.xaml?msg=" + (NewSelector.SelectedItem as Book).Title + "&ch=" + (NewSelector.SelectedItem as Book).chno, UriKind.Relative));
        }

        private void General_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Grid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            AboutPrompt aboutMe = new AboutPrompt();
            aboutMe.Show("Elroy Alva", "@elroyalva", "elroyalva197@hotmail.com");
        }

        private void Votd(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Read.xaml?msg=votd", UriKind.Relative));
        }

        private void rand(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Read.xaml?msg=random", UriKind.Relative));
        }

        private void rate(object sender, System.Windows.Input.GestureEventArgs e)
        {
            

        }

        void FeedbackOverlay_VisibilityChanged(object sender, EventArgs e)
        {
            ApplicationBar.IsVisible = (FeedbackOverlay.Visibility != Visibility.Visible);
        }
    }
}