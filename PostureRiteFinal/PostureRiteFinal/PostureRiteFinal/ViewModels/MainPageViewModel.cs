
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using PostureRiteFinal.Data;
using System.Windows.Input;
using Xamarin.Forms;

namespace PostureRiteFinal.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string managerLabel;
        private string employeeLabel;
        //since no login, hardcoded employee ID
        private int employeeID = 1;

        public string ManagerLabel
        {
            get { return managerLabel; }
            set
            {
                managerLabel = value;
            }
        }

        public string EmployeeLabel
        {
            get { return employeeLabel; }
            set
            {
                employeeLabel = value;
            }
        }

        INavigationService _navigationservice;
        public ICommand ManagerCommand { get; private set; }
        public ICommand EmployeeCommand { get; private set; }
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

            ManagerLabel = "Manager Login";
            ManagerCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.ManagerMainPage));

            Employee emp = App.Database.GetEmployee(employeeID);
            EmployeeLabel = "Employee Login: John Doe";
            EmployeeCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.EmployeeMainPage, emp));

        }
    }
}
