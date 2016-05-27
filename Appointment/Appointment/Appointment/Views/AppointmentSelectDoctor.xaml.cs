using Appointment.Classes;
using Appointment.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Appointment.Views
{
    public partial class AppointmentSelectDoctor : ContentPage
    {
        public AppointmentSelectDoctor()
        {
            InitializeComponent();
            BindingContext = new AppointmentSelectDoctorViewModel(SimpleIoc.Default.GetInstance<INavigationService>());

            SpecialistList.ItemsSource = new List<Specialist>
            {
                new Specialist
                {
                    Name = "Dr. Abraham",
                    Appointments = 2,
                    Specialty = "Ergonomist"
                },new Specialist
                {
                    Name = "Dr. Barkawi",
                    Appointments = 5,
                    Specialty = "Chiropractor"
                },new Specialist
                {
                    Name = "Dr. Hughes",
                    Appointments = 1,
                    Specialty = "Ergonomist"
                },new Specialist
                {
                    Name = "Dr. Turing",
                    Appointments = 0,
                    Specialty = "Counsellor"
                }
            };

            SpecialistList.ItemTapped += async (sender, e) => {
                await DisplayAlert("Tapped", e.Item + " row was tapped", "OK");
                Debug.WriteLine("Tapped: " + e.Item);
                ((ListView)sender).SelectedItem = null; // de-select the row
            };

        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return; // has been set to null, do not 'process' tapped event
            Debug.WriteLine("Tapped: " + e.Item);
            ((ListView)sender).SelectedItem = null; // de-select the row
        }
    }
}
