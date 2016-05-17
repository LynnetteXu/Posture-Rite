using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PostureRite.Pages
{
    public partial class UserReport : ContentPage
    {
        public UserReport()
        {
            InitializeComponent();
        }

        public void ShowFeedbackPageButton_Clicked(object sender, EventArgs e)
        {
            var currentNavPage = this;
            Navigation.PushAsync(new UserFeedbackPage());
        }
    }
}
