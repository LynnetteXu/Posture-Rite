using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using NewApps.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Xamarin.Forms;

namespace NewApps.Views
{
    public partial class EmployeePage : ContentPage
    {
        public EmployeePage()
        {
            InitializeComponent();
            BindingContext = new EmployeeViewModel(SimpleIoc.Default.GetInstance<INavigationService>());

        }
    }
}
