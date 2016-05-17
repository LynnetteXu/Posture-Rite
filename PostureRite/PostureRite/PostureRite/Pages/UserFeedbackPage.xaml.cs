using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PostureRite.Pages
{
    public partial class UserFeedbackPage : ContentPage
    {
        public UserFeedbackPage()
        {
            InitializeComponent();
        }

        public void BackToProfileButton_Clicked(object sender, EventArgs e)
        {
            // use boolean value to control special effect while switching page
            this.Navigation.PopAsync();
        }
    }
}
