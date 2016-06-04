using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PostureRiteFinal.Data;
using System.Diagnostics;

namespace PostureRiteFinal.ViewModels
{
    class TestPageViewModel : ViewModelBase
    {
        #region Binding data to setting page (replace with data from SQLite)

        private int bmi;
        public int BMI
        {
            get { return bmi; }

            set
            {
                bmi = value;
                RaisePropertyChanged(() => BMI);
            }
        }


        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                height = value;
                RaisePropertyChanged(() => Height);
            }
        }

        private int weight;
        public int Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                RaisePropertyChanged(() => Weight);
            }
        }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                RaisePropertyChanged(() => Gender);
            }
        }

        private int focusHour;
        public int FocusHour
        {
            get { return focusHour; }
            set
            {
                focusHour = value;
                RaisePropertyChanged(() => FocusHour);
            }
        }

        private int vibration;
        public int Vibration
        {
            get { return vibration; }
            set
            {
                vibration = value;
                RaisePropertyChanged(() => Vibration);
            }
        }

        private int ringDuration;
        public int RingDuration
        {
            get { return ringDuration; }
            set
            {
                ringDuration = value;
                RaisePropertyChanged(() => RingDuration);
            }
        }

        private bool pressureSensor;
        public bool PressureSensor
        {
            get { return pressureSensor; }
            set
            {
                pressureSensor = value;
                RaisePropertyChanged(() => PressureSensor);
            }
        }

        private bool angleSensor;
        public bool AngleSensor
        {
            get { return angleSensor; }
            set
            {
                angleSensor = value;
                RaisePropertyChanged(() => AngleSensor);
            }
        }

        #endregion

        // Binding Image sources
        private ImageSource ringImg;
        public ImageSource RingImg
        {
            get { return ringImg; }
            set
            {
                ringImg = value;
                RaisePropertyChanged(() => RingImg);
            }
        }

        private ImageSource vibraImg;
        public ImageSource VibraImg
        {
            get { return vibraImg; }
            set
            {
                vibraImg = value;
                RaisePropertyChanged(() => VibraImg);
            }
        }

        private INavigationService _navigationService;

        private string testStr;
        public string TestStr
        {
            get { return testStr; }
            set
            {
                testStr = value;
                RaisePropertyChanged(() => TestStr);
            }
        }

        private int employeeID;
        public int EmployeeID
        {
            get { return employeeID; }
            set
            {
                employeeID = value;
                RaisePropertyChanged(() => EmployeeID);
            }
        }

        public ICommand NextPageButtonCommmand { get; set; }
        public ICommand GoToMessageCommand { get; set; }

        public TestPageViewModel(INavigationService navService)
        {
            #region Binding data to setting value (Replace by data from SQLite)
            Employee emp = App.Database.GetEmployee(1);
            BMI = 23;
            Height = 190;
            Weight = 90;
            Gender = "Male";
            Vibration = 3;
            RingDuration = 5;
            FocusHour = 4;
            AngleSensor = true;
            PressureSensor = false;

            #endregion

            // Binding Image here (full file name include namespace and folder)
            RingImg = ImageSource.FromResource("PostureRiteFinal.Images.multimedia.png");
            VibraImg = ImageSource.FromResource("PostureRiteFinal.Images.cell-phone-vibration.png");


            _navigationService = navService;
            TestStr = "MVVM Light";    //Testing parsing data to next page

            // 按鈕換頁並且傳送資料
            NextPageButtonCommmand = new Command(() =>
            _navigationService.NavigateTo(Locator.SecondPage, TestStr));

            GoToMessageCommand = new Command(() =>
            _navigationService.NavigateTo(Locator.SecondPage, TestStr));
        }
    }
}
