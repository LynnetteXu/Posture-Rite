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
    public class AppointmentConfirmSpecialistViewModel: ViewModelBase
    {
        INavigationService _navigationservice;
        public ICommand NavigateCommand { get; private set; }
        public AppointmentConfirmSpecialistViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

            NavigateCommand = new Command(() =>
            _navigationservice.GoBack());
        }
    }
}
