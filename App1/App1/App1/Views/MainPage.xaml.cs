using App1.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()        
            //    (int slidVal)
        {
            InitializeComponent();
            BindingContext = new MainViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
            var vm3 = BindingContext as MainViewModel;
            vm3.SliderLabel = "Max Remind Time  (90 mins)";
        }

        public void OnClick(object sender, EventArgs e) {
            Navigation.PushAsync(new SecondPage("This is the second page (The easy way)"));
        }
        //void OnPickerSelectionIndexChanged(Object sender, EventArgs args)
        //{
        //    if (entry == null)
        //        return;

        //    Picker picker = (Picker)sender;
        //    int selectedIndex = picker.SelectedIndex;
        //}
    }

}
