using System;
using System.Collections.Generic;

using Xamarin.Forms;
using static Roma3Assistant.Services.Event;

namespace Roma3Assistant
{
    public partial class Calendario : ContentPage
    {
        public Calendario()
        {
            InitializeComponent();
            BindingContext = new BindingClass();
        }
    }
}
