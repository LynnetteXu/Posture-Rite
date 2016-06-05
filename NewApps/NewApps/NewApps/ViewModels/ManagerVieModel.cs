using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NewApps.ViewModels
{
    public class ManagerVieModel: ViewModelBase
    {
        private string managerName;

        public string ManagerName
        {
            get { return managerName; }
            set { managerName = value;
                RaisePropertyChanged(() => ManagerName);
            }
        }

        private ImageSource managerImg;
        public ImageSource ManagerImg
        {
            get { return managerImg; }
            set {
                managerImg = value;
                RaisePropertyChanged(() => ManagerImg);
            }
        }

        private INavigationService _navigationService;

        public ICommand NavPageCommand { get; private set; }

        public ManagerVieModel(INavigationService navService)
        {
            _navigationService = navService;
            ManagerName = "Andy Manager";
            ManagerImg = ImageSource.FromResource("NewApps.Images.BruceWayne.JPG");
            NavPageCommand = new Command(()=>
            _navigationService.NavigateTo(Locator.EmployeePage));
        }
    }
}
