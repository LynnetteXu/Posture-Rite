using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using PostureRiteFinal.Data;
using PostureRiteFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PostureRiteFinal.Pages
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
