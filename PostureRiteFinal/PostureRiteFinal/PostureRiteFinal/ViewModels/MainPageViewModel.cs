
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using PostureRiteFinal.Data;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace PostureRiteFinal.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string managerLabel;
        private string employeeLabel;
        private int employeeID;

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
        

        public int EmployeeID
        {
            get { return employeeID; }
            set
            {
                employeeID = value;
                RaisePropertyChanged(() => EmployeeID);
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
            _navigationservice.NavigateTo(Locator.ListViewList));

            EmployeeLabel = "Employee Login";
            EmployeeCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.EmployeeMain, EmployeeID));

        }
    }
}
