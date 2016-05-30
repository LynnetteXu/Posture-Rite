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
    public class AppointmentSelectDoctorViewModel: ViewModelBase
    {   

        INavigationService _navigationservice;
        public ICommand SelectSpecialistCommand { get; private set; }
        public AppointmentSelectDoctorViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

            SelectSpecialistCommand = new Command(() =>
            _navigationservice.GoBack());
        }
    }
}
