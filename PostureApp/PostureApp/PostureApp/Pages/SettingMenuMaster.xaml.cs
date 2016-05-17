using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PostureApp.Pages
{
    public partial class SettingMenuMaster : MasterDetailPage
    {
        public SettingMenuMaster()
        {
            InitializeComponent();
            this.Detail = new MainReport();
        }
    }
}
