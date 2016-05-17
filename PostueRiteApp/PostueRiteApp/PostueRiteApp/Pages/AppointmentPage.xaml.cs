using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PostueRiteApp.Pages
{
    public partial class AppointmentPage : ContentPage
    {
        
        public AppointmentPage()
        {
            InitializeComponent();
        }

        public void BackToProfileButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            App.Current.MainPage = new Pages.MenuTabPage();
            
        }
    }
}
