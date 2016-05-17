using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PostueRiteApp.Pages
{
    public partial class AppointmentPage : ContentPage
    {
        
        public AppointmentPage()
        {
            InitializeComponent();
            DoctorList.ItemsSource = new List<Doctor>
            {
                new Doctor
                {
                    Name = "Dr. Abraham",
                    Appointments = 2,
                    Specialty = "Ergonomist"
                },new Doctor
                {
                    Name = "Dr. Barkawi",
                    Appointments = 5,
                    Specialty = "Chiropractor"
                },new Doctor
                {
                    Name = "Dr. Hughes",
                    Appointments = 1,
                    Specialty = "Ergonomist"
                },new Doctor
                {
                    Name = "Dr. Turing",
                    Appointments = 0,
                    Specialty = "Counsellor"
                }
            };
        }

        public void BackToProfileButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            App.Current.MainPage = new Pages.MenuTabPage();
            
        }
    }
}
