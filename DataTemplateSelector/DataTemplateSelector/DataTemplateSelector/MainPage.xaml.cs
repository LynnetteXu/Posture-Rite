using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace DataTemplateSelector
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
           
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
