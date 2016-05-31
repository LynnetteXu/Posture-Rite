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
        /* private string buttonText;

          public string ButtonText
          {
              get { return buttonText; }
              set
              {
                  buttonText = value;
                  RaisePropertyChanged(() => ButtonText);
              }
          }
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
        private ObservableCollection<Employees> employee;
        public ObservableCollection<Employees> Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
                RaisePropertyChanged(() => Employee);
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


        private INavigationService _navigationService;
        //public ICommand ButtonCommand { get; set; }
        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Employee = new ObservableCollection<Employees>
            {
                new Employees { Name="Patrick", SeatId=5022, Score=Color.Black },
                 new Employees { Name="Patrick", SeatId=5022, Score=Color.Red },
                  new Employees { Name="Patrick", SeatId=5022, Score=Color.Green },
                   new Employees { Name="Patrick", SeatId=5022, Score=Color.Blue },
                    new Employees { Name="Patrick", SeatId=5022, Score=Color.Yellow },
                     new Employees { Name="Patrick", SeatId=5022, Score=Color.Teal }
            };
           /* if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;
            //ButtonText = "Move to next page";
            ButtonCommand = new Command(param =>
           _navigationService.NavigateTo(Locator.SingleEmployee, ((Employees)param).Name));*/
        }


    }
}