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
                await DisplayAlert("Tapped", sp.ToString() + " referred. Time of appointment to be confirmed by the employee.", "OK");
                ((ListView)sender).SelectedItem = null; // de-select the row
                await Navigation.PopAsync();
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

            //refetch specialist list, in case just populated.
            SpecialistList.ItemsSource = App.Database.GetSpecialists();
        }
    }
}
