using Appointment.Classes;
using Appointment.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Appointment.Views
{
    public partial class EmployeeAppointmentMain : ContentPage
    {
        public EmployeeAppointmentMain(Employee emp)
        {
            InitializeComponent();
            BindingContext = new EmployeeAppointmentMainViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
            var vm = BindingContext as EmployeeAppointmentMainViewModel;
            vm.EmpName = emp.Name;
            string appointmentBoolean = "No";
            if (emp.hasAppointment)
            {
                appointmentBoolean = "Yes";
            }
            vm.HasAppointment = "Has Appointment: " + appointmentBoolean;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;
        }
    }
}
