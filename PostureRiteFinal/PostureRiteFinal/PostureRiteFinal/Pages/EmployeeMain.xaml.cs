using PostureRiteFinal.Data;
using PostureRiteFinal.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

using Xamarin.Forms;

namespace PostureRiteFinal.Pages
{
    public partial class EmployeeMain : ContentPage
    {
        public EmployeeMain(Employee emp)
        {
            InitializeComponent();
            BindingContext = new EmployeeMainViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
            var vm = BindingContext as EmployeeMainViewModel;
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
