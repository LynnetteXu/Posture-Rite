
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostureRiteFinal.Data;

using Xamarin.Forms;
using PostureRiteFinal.Pages;

namespace PostureRiteFinal
{
    public class App : Application
    {
        //database 
        static PostureDB database;

        //employee logged in, assign id, then getemployee
        static Employee emp;
        static int employeeID = 0;
        public App()
        {
            var nav = new NavigationService();
            nav.Configure(Locator.MainPage, typeof(MainPage));
            //nav.Configure(Locator.AppointmentSelectDoctor, typeof(AppointmentSelectDoctor));
            //nav.Configure(Locator.AppointmentSelectTime, typeof(AppointmentSelectTime));
            //nav.Configure(Locator.AppointmentConfirmSpecialist, typeof(AppointmentConfirmSpecialist));
            nav.Configure(Locator.EmployeeMain, typeof(EmployeeMain));
            nav.Configure(Locator.EmployeeAppointment, typeof(EmployeeAppointment));
            nav.Configure(Locator.ListViewListPage, typeof(ListViewListPage));
            nav.Configure(Locator.SingleEmployee, typeof(SingleEmployee));
            nav.Configure(Locator.TestPage, typeof(TestPage));
            nav.Configure(Locator.SecondPage, typeof(ProfilePage));
            SimpleIoc.Default.Register<INavigationService>(() => nav);

            var mainPage = new NavigationPage(new MainPage());
            nav.Initialize(mainPage);
            // The root page of your application
            MainPage = mainPage;
        }

        public static PostureDB Database
        {
            get
            {
                if (database == null)
                {
                    database = new PostureDB();
                }
                return database;
            }
        }

        public static Employee loginEmployee
        {
            get
            {
                if (database != null && employeeID > 0)
                {
                    emp = database.GetEmployee(employeeID);
                }
                return emp;
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
