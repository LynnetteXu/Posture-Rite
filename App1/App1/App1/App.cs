using App1.Implementations;
using App1.Views;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class App : Application
    {
        public App()
        {
            PrepopulateData();

            var nav = new NavigationService();
            nav.Configure(Locator.MainPage, typeof(MainPage));
            nav.Configure(Locator.SecondPage, typeof(SecondPage));
            nav.Configure(Locator.MessagesPage, typeof(MessagesPage));
            SimpleIoc.Default.Register<INavigationService>(()=>nav);

            var mainPage = new NavigationPage(new MainPage());
            nav.Initialize(mainPage);
            // The root page of your application
            MainPage = mainPage;  

            
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

        public static void PrepopulateData()
        {
            List<string> defaultMessageList = new List<string>();
            defaultMessageList.Add("Straighten up, please");
            defaultMessageList.Add("Too many reminders today");
            defaultMessageList.Add("Your posture has been excellent today!");
            defaultMessageList.Add("Please come and see me");
         

        }
    }
}
