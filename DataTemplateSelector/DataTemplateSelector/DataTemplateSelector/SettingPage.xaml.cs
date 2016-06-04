using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTemplateSelector.ViewModels;
using Xamarin.Forms;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace DataTemplateSelector
{
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
            BindingContext = new SettingPageViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }
    }
}
