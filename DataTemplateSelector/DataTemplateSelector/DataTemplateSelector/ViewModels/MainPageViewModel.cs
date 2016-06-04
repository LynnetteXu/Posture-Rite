using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace DataTemplateSelector
{
    public class MainPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        private ObservableCollection<MessageViewModel> messagesList;

        public ObservableCollection<MessageViewModel> Messages
        {
            get { return messagesList; }
            set { messagesList = value; RaisePropertyChanged(() => Messages); }
        }

        private string outgoingText;

        public string OutGoingText
        {
            get { return outgoingText; }
            set { outgoingText = value; RaisePropertyChanged(() => OutGoingText); }
        }

        public ICommand SendCommand { get; set; }

        public ICommand BackCommand { get; set; }

        public MainPageViewModel(INavigationService navService)
        {
            _navigationService = navService;

            // Initialize with default values

            Messages = new ObservableCollection<MessageViewModel>
            {
                new MessageViewModel { Text = "How's going? \uD83D\uDE0A", IsIncoming = true, MessagDateTime = DateTime.Now.AddMinutes(-25)},
                new MessageViewModel { Text = "Hi, How are you? \uD83D\uDE0A", IsIncoming = false, MessagDateTime = DateTime.Now.AddMinutes(-24)},
                new MessageViewModel { Text = "Fine, thank you. How did you feel right now? \uD83D\uDE01", IsIncoming = true, MessagDateTime = DateTime.Now.AddMinutes(-23)},
                new MessageViewModel { Text = "We would love to know you're getting better!", IsIncoming = true, MessagDateTime = DateTime.Now.AddMinutes(-23)},
                new MessageViewModel { Text = "Yes I think so. \uD83D\uDE0E", IsIncoming = false, MessagDateTime = DateTime.Now.AddMinutes(-23)},
                new MessageViewModel { Text = "Thank you for asking. \uD83D\uDE48 \uD83D\uDE49 \uD83D\uDE49", IsIncoming = false, MessagDateTime = DateTime.Now.AddMinutes(-23)},

            };

            OutGoingText = null;

            SendCommand = new Command(() =>
            {
              Messages.Add(new MessageViewModel {Text =  OutGoingText, IsIncoming = false, MessagDateTime = DateTime.Now});
                OutGoingText = null;
            });

            // Navigate back to main page
            BackCommand = new Command(() =>
            _navigationService.NavigateTo(Locator.SettingPage));
        }
       // public List<MessageViewModel> Messages { get; set; } = new List<MessageViewModel>();

    }

    
}
