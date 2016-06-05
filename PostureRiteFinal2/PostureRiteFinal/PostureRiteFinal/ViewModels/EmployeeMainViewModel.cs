using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using PostureRiteFinal.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PostureRiteFinal.ViewModels
{
    class EmployeeMainViewModel : ViewModelBase
    {
        INavigationService _navigationservice;
        private string empName;
        private string hasAppointment;
        private string appointmentLabel;
        private int employeeID;

        public string EmpName
        {
            get { return empName; }
            set
            {
                empName = value;
                RaisePropertyChanged(() => EmpName);
            }
        }

        public int EmployeeID
        {
            get { return employeeID; }
            set
            {
                employeeID = value;
                RaisePropertyChanged(() => EmployeeID);
            }
        }

        public string HasAppointment
        {
            get { return hasAppointment; }
            set
            {
                hasAppointment = value;
                RaisePropertyChanged(() => HasAppointment);
            }
        }

        public string AppointmentLabel
        {
            get { return appointmentLabel; }
            set
            {
                appointmentLabel = value;
            }
        }

        public ICommand goBackCommand { get; private set; }
        public ICommand AppointmentCommand { get; private set; }
        public EmployeeMainViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

            goBackCommand = new Command(() =>
            _navigationservice.GoBack());
            AppointmentLabel = "Set Appointment Time";
            AppointmentCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.EmployeeAppointment, EmployeeID));
        }
    }
}
