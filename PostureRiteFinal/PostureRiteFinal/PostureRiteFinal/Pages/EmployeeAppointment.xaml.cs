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
    public partial class EmployeeAppointment : ContentPage
    {
        Employee emp;
        public EmployeeAppointment(int empID)
        {
            InitializeComponent();
            emp = App.Database.GetEmployee(empID);


            BindingContext = new EmployeeAppointmentViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
            var vm = BindingContext as EmployeeAppointmentViewModel;
            string appointmentBoolean = "No";
            string timeString = "No Appointment";
            string specName = "No Appointment";
            if (emp.hasAppointment)
            {
                appointmentBoolean = "Yes";
                if(emp.AppointmentDateTime == null)
                {
                    timeString = "Not Set";
                }
                else {
                    timeString = emp.AppointmentDateTime.ToString("dd/MM/yyyy HH:mm");
                }
               
                Specialist spec = App.Database.GetSpecialist(emp.AppointmentSpecID);
                specName = spec.ToString();
            }
            vm.HasAppointmentString = "Has Appointment: " + appointmentBoolean;
            vm.TimeString = timeString;
            vm.Name = emp.Name;
            vm.AppointmentSpec = specName;

            appButton.Clicked += appButtonClicked;
        }

        protected override void OnAppearing()
        {
            if (emp.hasAppointment)
            {
                appButton.IsVisible = true;
            }else {
                appButton.IsVisible = false;
            }
        }

        void appButtonClicked(object sender, EventArgs args)
        {
            appDatePicker.IsVisible = !appDatePicker.IsVisible;
            appDatePicker.Date = emp.AppointmentDateTime;


            appTimePicker.IsVisible = !appTimePicker.IsVisible;
            appTimePicker.Time = emp.AppointmentDateTime.TimeOfDay;
        }

    }
}
