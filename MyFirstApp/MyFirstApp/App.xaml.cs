using System;

using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MainPage());

            TabbedPage tabbedPage = new TabbedPage();

            //tabbedPage.Children.Add(new MainPage());

            var nav = new NavigationPage(new MainPage());
            nav.Title = "Navigation";
            tabbedPage.Children.Add(nav);
            tabbedPage.Children.Add(new SecondPage());
            tabbedPage.Children.Add(new ThirdPage());

            MainPage = tabbedPage;
        }
    }
}
