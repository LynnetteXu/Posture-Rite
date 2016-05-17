using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PostureRite
{
    public class App : Application
    {
        // Reset Navigation Page First
        public static NavigationPage NavPage = null;

        public App()
        {
            // Set "MenuMasterPage" as main page (All page setting is in "Pages" folder)
            // And "UserReport" as Navigation Page
            // Assign UserReport as Detail Page to Setting Menu (Master Page is set in XMAL file)
            NavigationPage _NavPage = new NavigationPage(new Pages.UserReport());
            var NewMasterDetailPage = new Pages.MenuMasterPage();
            NewMasterDetailPage.Detail = _NavPage;

            MainPage = NewMasterDetailPage;


            // Remove the default setting in order to user XAML to set different page

            //MainPage = new ContentPage
            //{
            //Content = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.Center,
            //    Children = {
            //        new Label {
            //            XAlign = TextAlignment.Center,
            //            Text = "Welcome to Xamarin Forms!"
            //        }
            //    }
            //}
            //};

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
