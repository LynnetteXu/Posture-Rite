using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin.Pages
{
    public partial class FirstPaage : ContentPage
    {
        public FirstPaage()
        {
            InitializeComponent();
            this.Appearing += FirstPaage_Appering;

        }

        private void FirstPaage_Appering(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            // Use Label Control "Title" and get data and display
            Title.Text = "My string";
        }
    }
}
