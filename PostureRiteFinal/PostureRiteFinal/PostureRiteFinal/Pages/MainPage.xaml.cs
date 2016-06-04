
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using PostureRiteFinal.Data;
using PostureRiteFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PostureRiteFinal.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }
        protected override void OnAppearing()
        {
            //Initialize database at start if empty, do all inserts here, 
            //since we dont have to update the db, this is the only place where db inserts.

            base.OnAppearing();
            // reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;

            //get all specialists from database
            var specialistList = App.Database.GetSpecialists();

            //count number of specialists in list
            int count = specialistList.Count();

            //if empty, populate.
            if (count < 1)
            {
                Specialist spec1 = new Specialist()
                {
                    Name = "Dr. Alan Turing",
                    Appointments = 5,
                    Specialty = "Ergonomist"
                };
                App.Database.SaveSpecialist(spec1);
                Specialist spec2 = new Specialist()
                {
                    Name = "Dr. Phil Dunphy",
                    Appointments = 2,
                    Specialty = "Chiropractor"
                };
                App.Database.SaveSpecialist(spec2);
                Specialist spec3 = new Specialist()
                {
                    Name = "Dr. Rick Grimes",
                    Appointments = 1,
                    Specialty = "Phsyciatrist"
                };
                App.Database.SaveSpecialist(spec3);
            }

            //get all specialists from database
            var employeeList = App.Database.GetEmployees();

            //count number of specialists in list
            count = employeeList.Count();
            
            //if empty, populate.
            if (count < 1)
            {
                App.Database.SaveEmployee(new Employee()
                {
                    Name = "John Doe",
                    AppointmentSpecID = 1,
                    hasAppointment = true,
                    AppointmentDateTime = new DateTime(2016, 6, 17, 17, 0, 0)
                });

                App.Database.SaveEmployee(new Employee()
                {
                    Name = "Rick Grimes",
                    hasAppointment = false
                });
            }
            

            var vm = BindingContext as MainPageViewModel;

            //login parameter to be binded here, if there is a login page, search for employee ID with username and updated EmployeeID binding.
            vm.EmployeeID = 1;

        }

    }
}
