using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PostueRiteApp.Pages
{
    public partial class ReportPage : ContentPage
    {
        public ReportPage()
        {
            InitializeComponent();
        }

        public void ShowAppointmentButton_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new Pages.AppointmentPage();
            App.Current.MainPage = new NavigationPage(new Pages.AppointmentPage());
        }
    }
}
