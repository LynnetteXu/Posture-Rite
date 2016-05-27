using Appointment.Implementations;
using Appointment.Views;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Appointment
{
    public class App : Application
    {
        public App()
        {
            var nav = new NavigationService();
            nav.Configure(Locator.AppointmentMain, typeof(AppointmentMain));
            nav.Configure(Locator.AppointmentSelectDoctor, typeof(AppointmentSelectDoctor));
            nav.Configure(Locator.AppointmentSelectTime, typeof(AppointmentSelectTime));
            SimpleIoc.Default.Register<INavigationService>(() => nav);

            var appointmentMain = new NavigationPage(new AppointmentMain());
            nav.Initialize(appointmentMain);
            // The root page of your application
            MainPage = appointmentMain;
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
