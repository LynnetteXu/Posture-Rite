using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewList.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {
        private string labelText;

        public string LabelText
        {
            get { return labelText; }
            set
            {
                labelText = value;
                RaisePropertyChanged(() => LabelText);
            }
        }

        public SecondViewModel(string param)
        {
            LabelText = param;
        }
    }
}