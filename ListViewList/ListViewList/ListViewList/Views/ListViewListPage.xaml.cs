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
using System.Diagnostics;

namespace ListViewList.Views
{

    public partial class ListViewListPage : ContentPage
    {


        public ListViewListPage()
        {

            InitializeComponent();

            BindingContext = new MainViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
            EmployeeList.ItemTapped += async (sender, e) =>
            {
                Employees sp = (Employees)e.Item;
                this.Navigation.PushAsync(new SingleEmployee(sp.Name));
            };
            }
        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return; // has been set to null, do not 'process' tapped event
            Debug.WriteLine("Tapped: " + e.Item);
            ((ListView)sender).SelectedItem = null; // de-select the row
        }


    }
}

