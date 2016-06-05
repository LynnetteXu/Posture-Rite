using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using NewApps.ViewModels;

namespace NewApps.Views
{
    public partial class ManagerPage : ContentPage
    {
        public ManagerPage()
        {
            InitializeComponent();
            BindingContext = new ManagerVieModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }
    }
}
