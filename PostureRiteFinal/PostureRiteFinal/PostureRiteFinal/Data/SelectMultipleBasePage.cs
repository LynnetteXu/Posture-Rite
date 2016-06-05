using System;

using Xamarin.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace PostureRiteFinal.Data
{
    public class SelectMultipleBasePage<T> : ContentPage
    {
       
        public class WrappedSelection<T> : INotifyPropertyChanged
        {
            public T Item { get; set; }
            bool isSelected = false;
            public bool IsSelected
            {
                get
                {
                    return isSelected;
                }
                set
                {
                    if (isSelected != value)
                    {
                        isSelected = value;
                        PropertyChanged(this, new PropertyChangedEventArgs("IsSelected"));
                        //						PropertyChanged (this, new PropertyChangedEventArgs (nameof (IsSelected))); // C# 6
                    }
                }
            }
            public event PropertyChangedEventHandler PropertyChanged = delegate { };
        }
        public class WrappedItemSelectionTemplate : ViewCell
        {
            public WrappedItemSelectionTemplate() : base()
            {

                Label name = new Label();
                name.SetBinding(Label.TextProperty, new Binding("Item.Name"));
                Label seatid = new Label();
                seatid.SetBinding(Label.TextProperty, new Binding("Item.SeatId"));
                BoxView score = new BoxView();
                //score.SetBinding(BoxView.ColorProperty, new Binding("Item.Score"));
                score.SetBinding(BoxView.ColorProperty, new Binding("Item.Score") { Converter = new ScoreColorConverter() });
                Switch mainSwitch = new Switch();
                mainSwitch.SetBinding(Switch.IsToggledProperty, new Binding("IsSelected"));

                Grid layout = new Grid();
                var chklist = App.Database.GetEmployees();
                int count = chklist.Count();
                while (count != 0)
                {
                    layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
                    count = count - 1;
                }
               
                layout.ColumnDefinitions.Add(new ColumnDefinition());
                layout.ColumnDefinitions.Add(new ColumnDefinition());
                layout.ColumnDefinitions.Add(new ColumnDefinition());
                layout.ColumnDefinitions.Add(new ColumnDefinition());
                

                layout.Children.Add(name,0,0);
                layout.Children.Add(seatid,1,0);
                layout.Children.Add(score,2,0);
                layout.Children.Add(mainSwitch,3,0);

                View = layout;

            }
        }
        public List<WrappedSelection<T>> WrappedItems = new List<WrappedSelection<T>>();

        public SelectMultipleBasePage(List<T> items)
        {
            
            WrappedItems = items.Select(item => new WrappedSelection<T>() { Item = item, IsSelected = false }).ToList();
            ListView mainList = new ListView()
            {
                ItemsSource = WrappedItems,
                ItemTemplate = new DataTemplate(typeof(WrappedItemSelectionTemplate)),
            };
            StackLayout layt = new StackLayout { Orientation = StackOrientation.Vertical };
            Button send = new Button { Text = "send" };
           // send.Clicked += OnButtonClicked;
            layt.Children.Add(mainList);
            layt.Children.Add(send);
            mainList.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem == null) return;
                var o = (WrappedSelection<T>)e.SelectedItem;
                o.IsSelected = !o.IsSelected;
                ((ListView)sender).SelectedItem = null; //de-select
            };

            Content = layt;
            ToolbarItems.Add(new ToolbarItem("All", null, SelectAll, ToolbarItemOrder.Primary));
            ToolbarItems.Add(new ToolbarItem("None", null, SelectNone, ToolbarItemOrder.Primary));

        }
       /* async void OnButtonClicked(object sender, EventArgs args)
        {
            string result = "";
            var answers = GetSelection();
            foreach (var a in answers)
            {
                result += a.Name + ", ";
            }
            if (result != "")
            {
                await DisplayAlert("Sent", "message has been sent to" + result, "OK");
}


        }*/
        void SelectAll()
        {
            foreach (var wi in WrappedItems)
            {
                wi.IsSelected = true;
            }
        }
         void SelectNone()
          {
              foreach (var wi in WrappedItems)
              {
                  wi.IsSelected = false;
              }
          }
        public List<T> GetSelection()
        {
            return WrappedItems.Where(item => item.IsSelected).Select(wrappedItem => wrappedItem.Item).ToList();
           
        }
        
    }
}
