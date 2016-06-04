using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using LayoutTest.ViewModels;    // 要匯進存放view model的資料夾
using GalaSoft.MvvmLight.Ioc;   // 使用simpleIoc
using GalaSoft.MvvmLight.Views;

namespace LayoutTest.Views
{
    public partial class TestPage : ContentPage
    {
      
        public TestPage()
        {
            InitializeComponent();

            BindingContext = new TestPageViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }
    }
}
