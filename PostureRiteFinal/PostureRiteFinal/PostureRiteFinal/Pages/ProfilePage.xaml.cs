using PostureRiteFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PostureRiteFinal.Pages
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage(string param)
        {
            InitializeComponent();
            BindingContext = new ProfilePageViewModel(param);
        }
        public ProfilePage()
        {
            InitializeComponent();
        }
    }
}
