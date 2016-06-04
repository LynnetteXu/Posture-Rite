using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
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
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = new ProfilePageViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }
    }
}
