using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewList
{
    public  class ScoreColorConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
            
            if ((int)value < 30)
            {
                return Color.Red;
            }
            if ((int)value>30 && (int)value<60)
            {
                return Color.Lime;
            }
            else
            {
                return Color.Blue;
            }
               
                
            }
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                return null;
            }
        }
}
