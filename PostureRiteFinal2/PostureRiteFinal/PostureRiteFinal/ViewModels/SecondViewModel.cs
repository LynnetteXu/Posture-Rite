using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostureRiteFinal.Pages;
using PostureRiteFinal;
using PostureRiteFinal.Data;
using Xamarin.Forms;

namespace PostureRiteFinal.ViewModels
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
        private int scoreText;

        public int ScoreText
        {
            get { return scoreText; }
            set
            {
                scoreText = value;
                RaisePropertyChanged(() => ScoreText);
            }
        }
        private int mscoreText;

        public int MScoreText
        {
            get { return mscoreText; }
            set
            {
                mscoreText = value;
                RaisePropertyChanged(() => MScoreText);
            }
        }
        private int tscoreText;

        public int TScoreText
        {
            get { return tscoreText; }
            set
            {
                tscoreText = value;
                RaisePropertyChanged(() => TScoreText);
            }
        }

        private ImageSource employeescore;
        public ImageSource EmployeeScore
        {
            get { return employeescore; }
            set
            {
                employeescore = value;
                RaisePropertyChanged(() => EmployeeScore);
            }
        }

        private ImageSource gRaph;
        public ImageSource graph
        {
            get { return gRaph; }
            set
            {
                gRaph = value;
                RaisePropertyChanged(() => graph);
            }
        }
        private string makecontact;
        public string MakeContact
        {
            get { return makecontact; }
            set
            {
                makecontact = value;
                RaisePropertyChanged(() => MakeContact);
            }
        }
        private string refertoergonomist;
        public string ReferToErgonomist
        {
            get { return refertoergonomist; }
            set
            {
               refertoergonomist = value;
                RaisePropertyChanged(() => ReferToErgonomist);
            }
        }
        private string currentscore;
        public string CurrentScore
        {
            get { return currentscore; }
            set
            {
                currentscore = value;
                RaisePropertyChanged(() => CurrentScore);
            }
        }
        private string monthlyscore;
        public string MonthlyScore
        {
            get { return monthlyscore; }
            set
            {
                monthlyscore = value;
                RaisePropertyChanged(() => MonthlyScore);
            }
        }

        private string totalscore;
        public string TotalScore
        {
            get { return totalscore; }
            set
            {
                totalscore = value;
                RaisePropertyChanged(() => TotalScore);
            }
        }



        public SecondViewModel(string param, int cScore, int mScore, int tScore)
        {
            LabelText = param;
            ScoreText = cScore;
            MScoreText = mScore;
            TScoreText = tScore;
            EmployeeScore = ImageSource.FromResource("PostureRiteFinal.Images.EmployeeScore.png");
            graph = ImageSource.FromResource("PostureRiteFinal.Images.graph.png");
            MakeContact = "Make Contact";
            ReferToErgonomist = "Refer to Ergonomist";
            CurrentScore = "Current Score";
            MonthlyScore = "Monthly Score";
            TotalScore = "Total Score";
        }
    }
}