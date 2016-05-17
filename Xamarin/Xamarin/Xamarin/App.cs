using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Pages;

namespace Xamarin
{
    public class App : Application
    {
        #region Create Main UI
        // To define the Main UI of Xamarin.Form app
        // Imstantiate a Page class
        // Populate it with Layouts and Controls
        // Assign to the App.MainPage property
        #endregion

        #region Markup as UI definition
        // Modern UI framewrks, default to markup languages for UI definition
        // HTML, AXML, XMAL
        #endregion

        public App()
        {
            // The root page of your application
            // MainPage = null;    // First let MainPage here is null to use XMAL setting
            MainPage = new FirstPaage();    // Once create Xaml page, assign your main page
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Start,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!",
            //                FontSize = 24
            //            },
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "This is the main page!",
            //                FontSize = 20
            //            }
            //        }
            //    }
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
