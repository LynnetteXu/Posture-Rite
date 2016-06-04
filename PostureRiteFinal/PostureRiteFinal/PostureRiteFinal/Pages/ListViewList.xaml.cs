using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostureRiteFinal.Data;

using Xamarin.Forms;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using PostureRiteFinal.ViewModels;

namespace PostureRiteFinal.Pages
{
    public partial class ListViewList : ContentPage
    {
        public ListViewList()
        {
            InitializeComponent();
            BindingContext = new ListViewListViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }
    }
}
