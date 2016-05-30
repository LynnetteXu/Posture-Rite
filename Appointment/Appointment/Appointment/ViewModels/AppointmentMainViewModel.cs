using Appointment.Implementations;
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
    public class AppointmentMainViewModel: ViewModelBase
    {
        private string selectDoctorLabel;
        private string selectTimeLabel;

        public string SelectDoctorLabel
        {
            get { return selectDoctorLabel; }
            set
            {
                selectDoctorLabel = value;
            }
        }

        public string SelectTimeLabel
        {
            get { return selectTimeLabel; }
            set
            {
                selectTimeLabel = value;
            }
        }

        INavigationService _navigationservice;
        public ICommand SelectDoctorCommand { get; private set; }
        public ICommand SelectTimeCommand { get; private set; }
        public AppointmentMainViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

            SelectDoctorLabel = "Select Doctor";
            SelectDoctorCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.AppointmentSelectDoctor));

            SelectTimeLabel = "Select Appointment Time";
            SelectTimeCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.AppointmentSelectTime));
        }
    }
}
