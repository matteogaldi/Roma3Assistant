using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Roma3Assistant
{
    public partial class WebView : ContentPage
    {
        public string webUrl { get; private set; }
        public WebView(string url)

        {
            InitializeComponent();
            webUrl = url;
            BindingContext = webUrl;
        }
    }
}
