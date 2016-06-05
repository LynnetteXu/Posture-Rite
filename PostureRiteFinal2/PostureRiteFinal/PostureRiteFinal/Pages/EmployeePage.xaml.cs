using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Xamarin.Forms;
using PostureRiteFinal.ViewModels;

namespace PostureRiteFinal.Pages
{
    public partial class EmployeePage : ContentPage
    {
        public EmployeePage()
        {
            InitializeComponent();
            BindingContext = new EmployeeViewModel(SimpleIoc.Default.GetInstance<INavigationService>());

        }
        async void upload(object sender, EventArgs ea)
        {


            await Navigation.PushAsync(new ManagerPage());
        }
    }
}