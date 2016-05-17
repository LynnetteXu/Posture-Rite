using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xam01.Pages
{
    public partial class FirstPage : ContentPage
    {
        string translatedNumber = "Show my phone number here";

        public FirstPage()
        {
            InitializeComponent();
            this.Appearing += FirstPage_Appearing;
        }

        private void FirstPage_Appearing(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            //phone_content.Text = translatedNumber;
        }

    }
}
