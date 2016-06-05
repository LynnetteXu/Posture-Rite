using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using GalaSoft.MvvmLight.Ioc;
using NewApps.Implementations;
using NewApps.Views;
using GalaSoft.MvvmLight.Views;

namespace NewApps
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var nav = new NavigationService();
            nav.Configure(Locator.EmployeePage, typeof(EmployeePage));
            nav.Configure(Locator.ManagerPage, typeof(ManagerPage));
            SimpleIoc.Default.Register<INavigationService>(() => nav);
            var mainPage = new NavigationPage(new EmployeePage());
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
