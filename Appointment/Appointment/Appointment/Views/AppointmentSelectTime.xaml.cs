using Appointment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Appointment.Views
{
    public partial class AppointmentSelectTime : ContentPage
    {
        public AppointmentSelectTime()
        {
            InitializeComponent();
            BindingContext = new AppointmentSelectTimeViewModel();
            var vm = BindingContext as AppointmentSelectTimeViewModel;
        }
    }
}
