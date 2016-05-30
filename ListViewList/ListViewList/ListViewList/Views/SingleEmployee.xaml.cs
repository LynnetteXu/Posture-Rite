using ListViewList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListViewList.Views
{
    public partial class SingleEmployee : ContentPage
    {
        public SingleEmployee(string param)
        {
            InitializeComponent();
            BindingContext = new SecondViewModel(param);
        }
    }
}
