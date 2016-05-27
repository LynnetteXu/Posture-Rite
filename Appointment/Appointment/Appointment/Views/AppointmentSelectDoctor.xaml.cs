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
        }
    }
}
