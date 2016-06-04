using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Windows.Input;
using Xamarin.Forms;
using GalaSoft.MvvmLight.Views;

namespace DataTemplateSelector.ViewModels
{
    public class SettingPageViewModel: ViewModelBase
    {
        private INavigationService _navigationService;

        public ICommand GoToAppointmentCommand { get; set; }
        public ICommand GoToFeedbackCommand { get; set; }
        

        public ICommand ShowInstructionCommand { get; set; }

        private string defaultMessage;
        public string DefaultMessage
        {
            get { return defaultMessage; }
            set { defaultMessage = value;
                RaisePropertyChanged(() => DefaultMessage);
            }
        }

        private string goodMessage;
        public string GoodMessage
        {
            get { return goodMessage; }
            set
            {
                goodMessage = value;
                RaisePropertyChanged(() => GoodMessage);
            }
        }

        private bool message01Valid;
        public bool Message01Valid
        {
            get { return message01Valid; }
            set { message01Valid = value;
                RaisePropertyChanged(() => Message01Valid);
            }
        }

        private bool message02Valid;
        public bool Message02Valid
        {
            get { return message02Valid; }
            set
            {
                message02Valid = value;
                RaisePropertyChanged(() => Message02Valid);
            }
        }

        private int focusHour;

        public int FocusHour
        {
            get { return focusHour; }
            set { focusHour = value;
                RaisePropertyChanged(() => FocusHour);
            }
        }

        public SettingPageViewModel(INavigationService navService)
        {
            _navigationService = navService;

            Message01Valid = true;
            Message02Valid = false;
            GoodMessage = "Good job! Keep your Posture!";
            DefaultMessage = "Pay attention to your Posture!";
            FocusHour = 4;
            
            ShowInstructionCommand = new Command(()=>
                                    Device.OpenUri(new Uri("https://www.google.com")));

            
            # region Modify this parts to navigate to correct pages

            // Go to Manager's Appointment Page
            GoToAppointmentCommand = new Command(() =>
            _navigationService.NavigateTo(Locator.MessagePage));
            // Go to Manager's Feedback Page
            GoToFeedbackCommand = new Command(() =>
            _navigationService.NavigateTo(Locator.MessagePage));


            #endregion
        }

    }
}
