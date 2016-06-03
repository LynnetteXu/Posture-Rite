using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Appointment.ViewModels
{
    class EmployeeAppointmentMainViewModel: ViewModelBase
    {
        INavigationService _navigationservice;
        private string empName;
        private string hasAppointment;

        public string EmpName
        {
            get { return empName; }
            set
            {
                empName = value;
                RaisePropertyChanged(() => EmpName);
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
        public ICommand goBackCommand { get; private set; }
        public EmployeeAppointmentMainViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

            goBackCommand = new Command(() =>
            _navigationservice.GoBack());
        }
    }
}
