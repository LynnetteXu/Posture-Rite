using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XaamarinDisplay.pages
{
    public partial class MainPage : ContentPage
    {
        string lineContent = "This is new line two";
        public MainPage()
        {
            InitializeComponent();
            this.Appearing += MainPage_Appearing;
        }

        private void MainPage_Appearing(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            line_two.Text = lineContent;
        }
        void ShowDetailsPageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailsPage());
            
        }
    }
}
