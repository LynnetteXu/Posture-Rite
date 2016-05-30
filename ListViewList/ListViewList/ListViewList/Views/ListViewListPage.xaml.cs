using ListViewList.Implementations;
using ListViewList.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using ListViewList.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ListViewList.Views
{

    public partial class ListViewListPage : ContentPage
    {


        public ListViewListPage()
        {

            InitializeComponent();

            BindingContext = new MainViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }

        public void ButtonClicked(object sender, EventArgs e)
        {

        }
    }
}

