using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {


        private string screenText;

        public string ScreenText
        {
            get { return screenText; }
            set { screenText = value;
                RaisePropertyChanged(() => ScreenText);
            }
        }

        public SecondViewModel()
        {
            
        }
    }
}
