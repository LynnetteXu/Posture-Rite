﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System.Windows.Input;
using Xamarin.Forms;
using PostureRiteFinal.Data;

namespace PostureRiteFinal.ViewModels
{
    public class EmployeeViewModel : ViewModelBase
    {
        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set
            {
                displayName = value;
                RaisePropertyChanged(() => DisplayName);
            }
        }

        private ImageSource userImg;
        public ImageSource UserImg
        {
            get { return userImg; }
            set
            {
                userImg = value;
                RaisePropertyChanged(() => UserImg);
            }
        }

        private INavigationService _navigationService;

        public ICommand NextPageCommand { get; set; }

        public EmployeeViewModel(INavigationService navService)
        {
            _navigationService = navService;
            DisplayName = "andy";
            UserImg = ImageSource.FromResource("PostureRiteFinal.Images.ClarkKent.JPG");
            
        }
    }
}