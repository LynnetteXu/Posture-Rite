using PostureRiteFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostureRiteFinal.Pages;

using Xamarin.Forms;

namespace PostureRiteFinal.Pages
{
    public partial class SingleEmployee : ContentPage
    {
        public SingleEmployee(string param, int cScore, int mScore, int tScore)
        {
            InitializeComponent();
            BindingContext = new SecondViewModel(param, cScore, mScore, tScore);
        }
        async void referSpecialist(object sender, EventArgs ea)
        {
            await Navigation.PushAsync(new AppointmentSelectDoc());
        }
        async void message(object sender, EventArgs ea)
        {
            await Navigation.PushAsync(new ChatPage());
        }
    }
}
