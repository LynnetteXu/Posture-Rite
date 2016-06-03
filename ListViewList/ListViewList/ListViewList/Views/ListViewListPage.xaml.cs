using ListViewList.Implementations;
using ListViewList.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using ListViewList.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

            MainViewModel viewmodel = new MainViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
            BindingContext = viewmodel;
            /*searchbar.TextChanged += (sender, e) => {
                viewmodel.FilterNames(searchbar.Text);
            };*/
            EmployeeList.ItemTapped += async (sender, e) => {
               Employee sp = (Employee)e.Item;
               this.Navigation.PushAsync(new SingleEmployee(sp.Name));
              //await Navigation.PopAsync();
            };

        }



        void OnItemTapped (object sender, ItemTappedEventArgs e) {
			if (e == null) return; // has been set to null, do not 'process' tapped event
			Debug.WriteLine("Tapped: " + e.Item);
			((ListView)sender).SelectedItem = null; // de-select the row
		}

      
    }
        }
    
