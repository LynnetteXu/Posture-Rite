using PostureRiteFinal.Data;
using PostureRiteFinal.Pages;
using PostureRiteFinal;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Diagnostics;

using PostureRiteFinal.ViewModels;

namespace PostureRiteFinal.Pages
{

    public partial class ListViewListPage : ContentPage
    {

        
        public ListViewListPage()
        {

            InitializeComponent();
           /* ListViewListViewModel viewmodel = new ListViewListViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
            BindingContext = viewmodel;*/

            searchbar.SearchButtonPressed += (sender, e) => {
                this.FilterLocations(searchbar.Text);
            };
            searchbar.TextChanged += (sender, e) => { this.FilterLocations(searchbar.Text); };
            EmployeeList.ItemTapped += async (sender, e) => {
                Employee sp = (Employee)e.Item;
                this.Navigation.PushAsync(new SingleEmployee(sp.Name, sp.Score, sp.MonthlyScore, sp.TotalScore));
                //await Navigation.PopAsync();
            };


            EmployeeList.ItemsSource = App.Database.GetEmployees();


        }
        public void FilterLocations(string filter)
        {
            if (string.IsNullOrWhiteSpace(filter))
            {
                EmployeeList.ItemsSource = App.Database.GetEmployees();
            }
            else
            {
                var FilteredList = App.Database.GetEmployees().Where(x => x.Name.ToLower().Contains(filter.ToLower()));
                EmployeeList.ItemsSource = FilteredList;
            }
        }
        SelectMultipleBasePage<Employee> multiPage;
        async void OnClick(object sender, EventArgs ea)
        {
            var items = new List<Employee>();
            var chklist = App.Database.GetEmployees();
            int count = 1;
            while (count <= chklist.Count())
            {
                items.Add(App.Database.GetEmployee(count));
                count = count + 1;
            }
            if (multiPage == null)
                multiPage = new SelectMultipleBasePage<Employee>(items) { Title = "Check all that apply" };

            await Navigation.PushAsync(multiPage);
        }
        async void OnSettingsClick(object sender, EventArgs ea)
        {
           

            await Navigation.PushAsync(new ManagerSettingsPage());
        }

        async void ManagerSettings(object sender, EventArgs ea)
        {
            await Navigation.PushAsync(new ManagerSettingsPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((App)App.Current).ResumeAtTodoId = -1;
            EmployeeList.SelectedItem = null;
            // reset the 'resume' id, since we just want to re-start here
            EmployeeList.ItemsSource = App.Database.GetEmployees();
            

            if (multiPage != null)
            {
                results.Text = "Sent to ";
                var answers = multiPage.GetSelection();
                foreach (var a in answers)
                {
                    results.Text += a.Name + ", ";
                }
            }
            else
            {
                results.Text = "";
            }
        }



    }
}

