using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LayoutTest.Implementations;   // 使用我們自建的navigation service
using LayoutTest.Views;             // 以及使用我們建立的頁面
using GalaSoft.MvvmLight.Views;     // 使用MVVMLight自己的Navigation service

using Xamarin.Forms;
using GalaSoft.MvvmLight.Ioc;

namespace LayoutTest
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            // MainPage = new Views.CalculatorPage();
            // MainPage = new Views.ProfilePage();
            // MainPage = new Views.TestPage();

            var nav = new NavigationService();
            nav.Configure(Locator.MainPage, typeof(TestPage));
            nav.Configure(Locator.SecondPage, typeof(ProfilePage));
            SimpleIoc.Default.Register<INavigationService>(() => nav);
            var mainPage = new NavigationPage(new TestPage());
            nav.Initialize(mainPage);

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
