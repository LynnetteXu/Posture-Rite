using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1.Views
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage(string param)
        {
            InitializeComponent();
            BindingContext = new SecondViewModel();
            var vm = BindingContext as SecondViewModel ;
            vm.ScreenText = param;
            
        }
    }
}
