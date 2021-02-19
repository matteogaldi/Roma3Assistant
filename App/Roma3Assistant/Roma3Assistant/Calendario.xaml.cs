using System;
using System.Collections.Generic;

using Xamarin.Forms;
using static Roma3Assistant.Services.Event;

namespace Roma3Assistant
{
    public partial class Calendario : ContentPage
    {
        public BindingClass Eventi = new BindingClass();
        public Calendario()
        {
            InitializeComponent();
            BindingContext = Eventi;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewEvent(Eventi));
        }
    }
}
