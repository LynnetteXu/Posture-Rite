using App1.Implementations;
using App1.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string buttonLabel;
        private static int sliderValue = 90;
        private string sliderLabel = "Max Remind Time (" + sliderValue.ToString() +" mins)";


        public string ButtonLabel
        {
            get { return buttonLabel; }
            set { buttonLabel = value;
                RaisePropertyChanged(() => ButtonLabel);
            }
        }
        public string SliderLabel
        {
            get { return sliderLabel; }
            set
            {
                sliderLabel = value;
                RaisePropertyChanged(() => SliderLabel);
            }
        }
        public int SliderValue
        {
            get { return sliderValue; }
            set { sliderValue = value;
                RaisePropertyChanged(() => SliderValue);
            }
        }
        INavigationService _navigationservice;
        public ICommand ButtonCommand { get; private set; }
        public MainViewModel(INavigationService navigationService) {
            _navigationservice = navigationService;
            ButtonLabel = "Manage default messages";
            ButtonCommand = new Command(() => 
            _navigationservice.NavigateTo(Locator.MessagesPage, "This is the Messages Page"));

        }

    }
}
