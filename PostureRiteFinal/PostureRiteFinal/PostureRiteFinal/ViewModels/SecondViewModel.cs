using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public SecondViewModel(string param, int cScore, int mScore, int tScore)
        {
            LabelText = param;
            ScoreText = cScore;
            MScoreText = mScore;
            TScoreText = tScore;
        }
    }
}