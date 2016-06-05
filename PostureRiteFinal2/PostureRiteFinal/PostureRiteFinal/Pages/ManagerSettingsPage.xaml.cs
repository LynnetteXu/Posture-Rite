using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PostureRiteFinal.Pages
{
    public partial class ManagerSettingsPage : ContentPage
    {
        public ManagerSettingsPage()
        {
            InitializeComponent();
        }
        async void feedback(object sender, EventArgs ea)
        {


            await Navigation.PushAsync(new EmployeePage());
        }
    }
}
