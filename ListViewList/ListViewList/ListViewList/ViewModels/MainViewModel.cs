using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ListViewList.Views;

namespace ListViewList.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        /* 
          private string entryText;
         public string EntryText
         {
             get { return entryText; }
             set
             {
                 entryText = value;
                 RaisePropertyChanged(() => EntryText);
             }
         }*/
        private ObservableCollection<Employee> employee;
        public ObservableCollection<Employee> Employees {
            get
            {
                return employee;
            }
            set {employee = value;
                RaisePropertyChanged(() => Employees);
            }
        }
        private string name;

        
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        public ICommand SearchBarCommand { get; private set; }
        private INavigationService _navigationService;
       // public ICommand ButtonCommand { get; set; }
        public MainViewModel(INavigationService navigationService)
        {
            SearchBarCommand = new Command(searchTerm => 
            {
                FilterNames(searchTerm.ToString());
            });
            _navigationService = navigationService;
            Employees = new ObservableCollection<Employee>
            {
                new Employee { Name="Patrick", SeatId=5022, Score=Color.Black },
                 new Employee { Name="Spongebob", SeatId=22, Score=Color.Red },
                  new Employee { Name="Peter", SeatId=992, Score=Color.Green },
                   new Employee { Name="Clark", SeatId=444, Score=Color.Blue },
                    new Employee { Name="Natasha", SeatId=6662, Score=Color.Yellow },
                     new Employee { Name="Mr. Crab", SeatId=1000, Score=Color.Teal }
            };
           /* if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;
            //ButtonText = "Move to next page";
            ButtonCommand = new Command(param =>
           _navigationService.NavigateTo(Locator.SingleEmployee, ((Employees)param).Name));*/
        }
        public void FilterNames(string filter)
        {
             Employees.Clear();
            if (String.IsNullOrEmpty(filter))
            {
                var FilteredList =  Employees.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
               
                foreach (var item in FilteredList)
                {
                    Employees.Add(item);
                }
                RaisePropertyChanged(() => Employees);
            }



        }

    }
}