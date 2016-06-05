using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostureRiteFinal.Pages;
using Xamarin.Forms;

namespace PostureRiteFinal
{
    public partial class ChatPage : ContentPage
    {
        public ChatPage()
        {
            InitializeComponent();
            Title = "Monkey Chat";
            BindingContext = new ChatViewModel();

        }

        private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MessagesListView.SelectedItem = null;
        }

        private void MyListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            MessagesListView.SelectedItem = null;

        }
    }
}