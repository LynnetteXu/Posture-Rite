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
            

            SpecialistList.ItemTapped += async (sender, e) => {
                Specialist sp = (Specialist)e.Item;
                await DisplayAlert("Tapped", sp.ToString() + " referred", "OK");
                ((ListView)sender).SelectedItem = null; // de-select the row
            };

        }

        void OnItemTapped (object sender, ItemTappedEventArgs e) {
			if (e == null) return; // has been set to null, do not 'process' tapped event
			Debug.WriteLine("Tapped: " + e.Item);
			((ListView)sender).SelectedItem = null; // de-select the row
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;

            //get all specialists from database
            var specialistList = App.Database.GetSpecialists();

            //count number of specialists in list
            int count = specialistList.Count();

            //if empty, populate.
            if (count < 1)
            {
                Specialist spec1 = new Specialist()
                {
                    Name = "Dr. Alan Turing",
                    Appointments = 5,
                    Specialty = "Ergonimost"
                };
                App.Database.SaveSpecialist(spec1);
                Specialist spec2 = new Specialist()
                {
                    Name = "Dr. Phil Dunphy",
                    Appointments = 2,
                    Specialty = "Chiropractor"
                };
                App.Database.SaveSpecialist(spec2);
                Specialist spec3 = new Specialist()
                {
                    Name = "Dr. Rick Grimes",
                    Appointments = 1,
                    Specialty = "Phsyciatrist"
                };
                App.Database.SaveSpecialist(spec3);
            }

            //refetch specialist list, in case just populated.
            SpecialistList.ItemsSource = App.Database.GetSpecialists();
        }
    }
}
