using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PostureRiteFinal
{
    public class ScoreColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if ((int)value>0 && (int)value < 20)
            {
                return Color.Red;
            }
            if ((int)value >= 20 && (int)value < 40)
            {
                return Color.Fuchsia;
            }
            if ((int)value >= 40 && (int)value < 60)
            {
                return Color.Yellow;
            }
            if ((int)value >= 60 && (int)value < 80)
            {
                return Color.Lime;
            }
            if ((int)value >= 100)
            {
                return Color.Green;
            }
            else
            {
                return Color.Gray;
            }


        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
