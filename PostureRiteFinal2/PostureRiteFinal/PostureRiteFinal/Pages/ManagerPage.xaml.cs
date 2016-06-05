using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using PostureRiteFinal.ViewModels;

namespace PostureRiteFinal.Pages
{
    public partial class ManagerPage : ContentPage
    {
        public ManagerPage()
        {
            InitializeComponent();
            BindingContext = new ManagerVieModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }
        async void upload(object sender, EventArgs ea)
        {


            await Navigation.PushAsync(new EmployeePage());
        }
    }
}