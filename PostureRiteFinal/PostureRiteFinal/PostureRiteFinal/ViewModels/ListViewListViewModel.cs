using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRiteFinal.ViewModels
{
    class ListViewListViewModel: ViewModelBase
    {
        INavigationService _navigationservice;

        public ListViewListViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;
        }
    }


}
