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
        int employeeid = 1;
        public EmployeeAppointmentMain()
        {
            InitializeComponent();
            BindingContext = new EmployeeAppointmentMainViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;

            Employee e = App.Database.GetEmployee(1);
            //how to put this into label??
        }
    }
}
