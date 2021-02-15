using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Roma3Assistant
{
    public partial class Notizie : ContentPage
    {
        public Notizie()
        {
            InitializeComponent();
            var browser = new WebView
            {
                Source = "https://www.uniroma3.it"
            };
        }
    }
}
