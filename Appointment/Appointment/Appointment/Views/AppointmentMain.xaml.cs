using Appointment.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Appointment.Views
{
    public partial class AppointmentMain : ContentPage
    {
        public AppointmentMain()
        {
            InitializeComponent();
            BindingContext = new AppointmentMainViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }

        
    }
}
