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

namespace DataTemplateSelector
{
    public class MainPageViewModel : ViewModelBase
    {

        private ObservableCollection<MessageViewModel> messagesList;

        public ObservableCollection<MessageViewModel> Messages
        {
            get { return messagesList; }
            set { messagesList = value; RaisePropertyChanged(); }
        }

        private string outgoingText;

        public string OutGoingText
        {
            get { return outgoingText; }
            set { outgoingText = value; RaisePropertyChanged(); }
        }

        public ICommand SendCommand { get; set; }

        public ICommand BackCommand { get; set; }

        


        public MainPageViewModel()
        {
              // Initialize with default values

            Messages = new ObservableCollection<MessageViewModel>
            {
                new MessageViewModel { Text = "Hi Clark.  I've noticed you've had three reminders today.  Are you ok? ", IsIncoming = false, MessagDateTime = DateTime.Now.AddMinutes(-14)},
                new MessageViewModel { Text = "I had a bad night with my back - finding it had to stay straight. ", IsIncoming = true, MessagDateTime = DateTime.Now.AddMinutes(-13)},
                new MessageViewModel { Text = "Would you like me to set up a referral?", IsIncoming = false, MessagDateTime = DateTime.Now.AddMinutes(-13)},
                new MessageViewModel { Text = "That would be good! ", IsIncoming = true, MessagDateTime = DateTime.Now.AddMinutes(-13)},


            };
            OutGoingText = null;
            SendCommand = new Command(() =>
            {
              Messages.Add(new MessageViewModel {Text =  OutGoingText, IsIncoming = false, MessagDateTime = DateTime.Now});
                OutGoingText = null;
            });
            BackCommand = new Command(() => { });

        }
       // public List<MessageViewModel> Messages { get; set; } = new List<MessageViewModel>();

    }

    
}
