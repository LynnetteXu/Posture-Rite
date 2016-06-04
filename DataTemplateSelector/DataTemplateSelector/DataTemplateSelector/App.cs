using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GalaSoft.MvvmLight.Ioc;
using DataTemplateSelector.Implementations;   
using GalaSoft.MvvmLight.Views;     
using Xamarin.Forms;

namespace DataTemplateSelector
{
    public class App : Application
    {
        public App()
        {
            var nav = new NavigationService();
            nav.Configure(Locator.MessagePage, typeof(MainPage));
            nav.Configure(Locator.SettingPage, typeof(SettingPage));
            SimpleIoc.Default.Register<INavigationService>(() => nav);
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
    }
}
