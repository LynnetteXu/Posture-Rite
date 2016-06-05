using App1;
using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1.Views
{
    public partial class MessagesPage : ContentPage
    {
        public MessagesPage( string param)
        {
            InitializeComponent();
            BindingContext = new MessagesViewModel();
            //var messageToSend = new ListView();
            //messageToSend.ItemsSource = defaultMessageList<>;


            //         var vm2 = BindingContext as MessagesViewModel;
            //         vm2.MessageText = param;


        }
    }
}
