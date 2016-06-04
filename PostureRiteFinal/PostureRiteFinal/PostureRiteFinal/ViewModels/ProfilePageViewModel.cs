using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using PostureRiteFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PostureRiteFinal.ViewModels
{
    public class ProfilePageViewModel : ViewModelBase
    {
        // Future binding from database class
        private Data.Employee user;

        #region Binding images, commands and individual profile (Replace with SQLite class)

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

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                RaisePropertyChanged(() => Description);
            }
        }

        private string posture;
        public string Posture
        {
            get { return posture; }
            set
            {
                posture = value;
                RaisePropertyChanged(() => Posture);
            }
        }

        private string chairStaus;
        public string ChairStatus
        {
            get { return chairStaus; }
            set
            {
                chairStaus = value;
                RaisePropertyChanged(() => ChairStatus);
            }
        }

        private string seatingTime;
        public string SeatingTime
        {
            get { return seatingTime; }
            set
            {
                seatingTime = value;
                RaisePropertyChanged(() => SeatingTime);
            }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                RaisePropertyChanged(() => Message);
            }
        }

        private int postureScore;
        public int PostureScore
        {
            get { return postureScore; }
            set
            {
                postureScore = value;
                RaisePropertyChanged(() => PostureScore);
            }
        }

        private int monthlyScore;
        public int MonthlyScore
        {
            get { return monthlyScore; }
            set
            {
                monthlyScore = value;
                RaisePropertyChanged(() => MonthlyScore);
            }
        }

        private int todayScore;
        public int TodayScore
        {
            get { return todayScore; }
            set
            {
                todayScore = value;
                RaisePropertyChanged(() => TodayScore);
            }
        }


        private ImageSource avatarImg;
        public ImageSource AvatarImg
        {
            get { return avatarImg; }
            set
            {
                avatarImg = value;
                RaisePropertyChanged(() => AvatarImg);
            }
        }

        private ImageSource warningImg;
        public ImageSource WarningImg
        {
            get { return warningImg; }
            set
            {
                warningImg = value;
                RaisePropertyChanged(() => WarningImg);
            }
        }

        private ImageSource postureImg;
        public ImageSource PostureImg
        {
            get { return postureImg; }
            set
            {
                postureImg = value;
                RaisePropertyChanged(() => PostureImg);
            }
        }

        private ImageSource scoreImg;
        public ImageSource ScoreImg
        {
            get { return scoreImg; }
            set
            {
                scoreImg = value;
                RaisePropertyChanged(() => ScoreImg);
            }
        }

        public ICommand NextPageButtonCommmand { get; set; }

        #endregion


        #region Setting Colors

        private Color scoreColour;
        public Color ScoreColour
        {
            get { return scoreColour; }
            set
            {
                scoreColour = value;
                RaisePropertyChanged(() => ScoreColour);
            }
        }

        private Color monthlyScoreColour;
        public Color MonthlyScoreColour
        {
            get { return monthlyScoreColour; }
            set
            {
                monthlyScoreColour = value;
                RaisePropertyChanged(() => MonthlyScoreColour);
            }
        }

        private Color dailyScoreColour;
        public Color DailyScoreColour
        {
            get { return dailyScoreColour; }
            set
            {
                dailyScoreColour = value;
                RaisePropertyChanged(() => DailyScoreColour);
            }
        }

        #endregion

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

        private string appointmentLabel;
        public string AppointmentLabel
        {
            get { return appointmentLabel; }
            set
            {
                appointmentLabel = value;
            }
        }

        INavigationService _navigationservice;
        public ICommand AppointmentCommand { get; private set; }
        public ProfilePageViewModel(INavigationService navigationService)
        {
            user = new Data.Employee();


            #region Binding data (Replace with data class from SQLite)

            Name = "John Smith";
            Description = "Head of Sales Departmant";
            PostureScore = 53;
            MonthlyScore = 86;
            TodayScore = 60;
            SeatingTime = "03:38";
            Posture = "Leg-Crossed";
            ChairStatus = "Occcupied";
            Message = "Take a Break";

            #endregion

            #region Display color

            ScoreColour = StringColor(PostureScore);
            DailyScoreColour = StringColor(TodayScore);
            MonthlyScoreColour = StringColor(MonthlyScore);

            #endregion

            // Binding Image here (full file name include namespace and folder)
            AvatarImg = ImageSource.FromResource("PostureRiteFinal.Images.Android-icon-m.png");

            ScoreImg = ImageSource.FromResource("PostureRiteFinal.Images.progress-default.png");
            PostureImg = ImageSource.FromResource("PostureRiteFinal.Images.Posture-defaut.png");
            WarningImg = ImageSource.FromResource("PostureRiteFinal.Images.Warning-icon-64.png");

            _navigationservice = navigationService;

            int employeeID = 1;
            AppointmentLabel = "Set Appointment";
            AppointmentCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.EmployeeAppointment, employeeID));

        }

        public Color StringColor(int score)
        {
            Color color = Color.White;
            if (score >= 80)
            {
                color = Color.Green;
            }
            else if (score < 80 && score >= 60)
            {
                color = Color.Purple;
            }
            else if (score < 60 && score >= 40)
            {
                color = Color.Yellow;
            }
            else
            {
                color = Color.Red;
            }

            return color;
        }

    }
}
