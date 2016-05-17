using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XaamarinDisplay.pages
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
            this.Appearing += DetailsPage_Appearing;

        }

        private void DetailsPage_Appearing(object sender, EventArgs e)
        {
            
        }

        private void BackToMainPageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync(false);
        }
    }
}
