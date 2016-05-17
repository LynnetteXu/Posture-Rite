using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PostureRite.Pages
{
    public partial class MenuMasterPage : MasterDetailPage
    {
        public MenuMasterPage()
        {
            InitializeComponent();
            // this.Detail = new UserReport();
        }

        public void FeedbackButton_Clicked(object sender, EventArgs e)
        {
            this.Detail = new Pages.UserFeedbackPage();
            this.IsPresented = false;
        }
    }
}
