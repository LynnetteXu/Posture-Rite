using PostureRiteFinal.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PostureRiteFinal
{
    class MyDataTemplateSelector : Xamarin.Forms.PostureRiteFinal
    {
        public MyDataTemplateSelector()
        {
            // Retain instances!
            this.incomingDataTemplate = new DataTemplate(typeof(IncomingViewCell));
            this.outgoingDataTemplate = new DataTemplate(typeof(OutgoingViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVm = item as MessageViewModel;
            if (messageVm == null)
                return null;
            return messageVm.IsIncoming ? this.incomingDataTemplate : this.outgoingDataTemplate;
        }

        private readonly DataTemplate incomingDataTemplate;
        private readonly DataTemplate outgoingDataTemplate;
    }
}