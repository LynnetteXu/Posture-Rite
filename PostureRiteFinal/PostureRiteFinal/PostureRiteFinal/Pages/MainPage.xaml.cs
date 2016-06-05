
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
            managercommand.Clicked+= (sender, e) => {
                this.Navigation.PushAsync(new ListViewListPage());
                //await Navigation.PopAsync();
            };
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

            //count number of employees in list
            count = employeeList.Count();
            
            //if empty, populate.
            if (count < 1)
            {
                Employee emp1 = new Employee()
                {
                    Name = "Peter",
                    AppointmentSpecID = 1,
                    hasAppointment = true,
                    AppointmentDateTime = new DateTime(2016, 6, 17, 17, 0, 0),
                    Description = "Head of Sales Departmant",
                    PostureScore = 53, 
                    TodayScore = 60,
                    Posture = "Leg-Crossed",
                    ChairStatus = "Occcupied",
                    BMI = 23,
                    Height = 190,
                    Weight = 90,
                    Gender = "Male",
                    Vibration = 3,
                    RingDuration = 5,
                    FocusHour = 4,
                    AngleSenssor = true,
                    PressureSensor = false,
                    SeatId = 505,
                    Score = 10,
                    MonthlyScore = 50,
                    TotalScore = 78
                };
                App.Database.SaveEmployee(emp1);
                Employee emp2 = new Employee()
                {
                    Name = "John Doe",
                    SeatId = 995,
                    Score = 20,
                    MonthlyScore = 48,
                    TotalScore = 92
                };
                App.Database.SaveEmployee(emp2);
                Employee emp3 = new Employee()
                {
                    Name = "Natasha",
                    SeatId = 1,
                    Score = 50,
                    MonthlyScore = 10,
                    TotalScore = 40
                };
                App.Database.SaveEmployee(emp3);
                Employee emp4 = new Employee()
                {
                    Name = "Bob",
                    SeatId = 1000,
                    Score = 100,
                    MonthlyScore = 22,
                    TotalScore = 88
                };
                App.Database.SaveEmployee(emp4);
                Employee emp5 = new Employee()
                {
                    Name = "Patrick",
                    SeatId = 200,
                    Score = 70,
                    MonthlyScore = 33,
                    TotalScore = 98
                };
                App.Database.SaveEmployee(emp5);
                Employee emp6 = new Employee()
                {
                    Name = "Lily",
                    SeatId = 9672,
                    Score = 40,
                    MonthlyScore = 88,
                    TotalScore = 10
                };
                App.Database.SaveEmployee(emp6);
               

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
