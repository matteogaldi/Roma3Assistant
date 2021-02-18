using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Roma3Assistant
{
    public partial class WebView : ContentPage
    {
       public Uri webUrl { get; private set; }
        public WebView( Uri uri)

        {
            InitializeComponent();
            webUrl = uri;
            BindingContext = webUrl.AbsoluteUri;
        }
    }
}
