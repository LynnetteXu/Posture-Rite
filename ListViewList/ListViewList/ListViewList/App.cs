using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using ListViewList.Implementations;
using ListViewList.Views;
using System;
using Xamarin.Forms;

namespace ListViewList
{
    public class App : Application
    {
        static EmployeeDatabase database;
        public App()
        {
            var nav = new NavigationService();
            nav.Configure(Locator.ListViewListPage, typeof(ListViewListPage));
            nav.Configure(Locator.SingleEmployee, typeof(SingleEmployee));
            SimpleIoc.Default.Register<INavigationService>(() => nav);
            var mainPage = new NavigationPage(new ListViewListPage());
            nav.Initialize(mainPage);
            MainPage = mainPage;
            //ListViewListPage = mainPage;
        }
        public static EmployeeDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new EmployeeDatabase();
                }
                return database;
            }
        }
        public int ResumeAtTodoId { get; set; }
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
