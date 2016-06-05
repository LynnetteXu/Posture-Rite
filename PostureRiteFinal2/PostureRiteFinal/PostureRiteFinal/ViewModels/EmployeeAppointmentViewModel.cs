using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using PostureRiteFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PostureRiteFinal.ViewModels
{
    class EmployeeAppointmentViewModel: ViewModelBase
    {
        INavigationService _navigationservice;
        private string name;
        private bool hasAppointment;
        private string appointmentSpec;
        private DateTime appointmentDate;
        private string timeString;
        private string hasAppointmentString;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged(() => Name);
            }
        }
        public bool HasAppointment
        {
            get { return hasAppointment; }
            set
            {
                hasAppointment = value;
                RaisePropertyChanged(() => HasAppointment);
            }
        }

        public string HasAppointmentString
        {
            get { return hasAppointmentString; }
            set
            {
                hasAppointmentString = value;
                RaisePropertyChanged(() => HasAppointmentString);
            }
        }

        public string AppointmentSpec
        {
            get { return appointmentSpec; }
            set
            {
                appointmentSpec = value;
                RaisePropertyChanged(() => AppointmentSpec);
            }
        }

        public DateTime AppointmentDate
        {
            get { return appointmentDate; }
            set
            {
                appointmentDate = value;
                RaisePropertyChanged(() => AppointmentDate);
            }
        }

        public string TimeString
        {
            get { return timeString; }
            set
            {
                timeString = value;
                RaisePropertyChanged(() => TimeString);
            }
        }

        public ICommand goBackCommand { get; private set; }
        public ICommand SetAppointmentCommand { get; private set; }
        public EmployeeAppointmentViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

            goBackCommand = new Command(() =>
            _navigationservice.GoBack());

            SetAppointmentCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.EmployeeMain));
        }
    }
}
