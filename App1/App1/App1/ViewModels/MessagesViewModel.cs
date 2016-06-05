using App1;
using GalaSoft.MvvmLight;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModels
{
    public class MessagesViewModel : ViewModelBase
    {

  
        private string messageText;

   
        public string MessageText
        {
            get { return messageText; }
            set
            {
                messageText = value;
                RaisePropertyChanged(() => MessageText);
            }
        }

        public MessagesViewModel()
        {

        }
    }

}
