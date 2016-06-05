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
            var employeeList = App.Database.GetEmployees();

            //count number of specialists in list
            int count = employeeList.Count();

            //if empty, populate.
            if (count < 1)
            {
                Employee emp1 = new Employee()
                {
                    Name = "Peter",
                    SeatId = 505,
                    Score = 10,
                    MonthlyScore = 50,
                    TotalScore = 78
                };
                App.Database.SaveEmployee(emp1);
                Employee emp2 = new Employee()
                {
                    Name = "Clark",
                    SeatId = 995,
                    Score = 20,
                    MonthlyScore = 48,
                    TotalScore = 92
                };
                App.Database.SaveEmployee(emp2);
                Employee emp3 = new Employee()
                {
                    Name = "Natasha",
                    SeatId = 1,
                    Score = 50,
                    MonthlyScore = 10,
                    TotalScore = 40
                };
                App.Database.SaveEmployee(emp3);
                Employee emp4 = new Employee()
                {
                    Name = "Bob",
                    SeatId = 1000,
                    Score = 100,
                    MonthlyScore = 22,
                    TotalScore = 88
                };
                App.Database.SaveEmployee(emp4);
                Employee emp5 = new Employee()
                {
                    Name = "Patrick",
                    SeatId = 200,
                    Score = 70,
                    MonthlyScore = 33,
                    TotalScore = 98
                };
                App.Database.SaveEmployee(emp5);
                Employee emp6 = new Employee()
                {
                    Name = "Lily",
                    SeatId = 9672,
                    Score = 40,
                    MonthlyScore = 88,
                    TotalScore = 10
                };
                App.Database.SaveEmployee(emp6);

            }

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

