using Appointment.Classes;
using Appointment.ViewModels;
using System;
using System.Collections.Generic;
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
            BindingContext = new AppointmentSelectDoctorViewModel();
            var vm = BindingContext as AppointmentSelectDoctorViewModel;

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
        }
    }
}
