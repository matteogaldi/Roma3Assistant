using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;

namespace Roma3Assistant
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Roma3Assistant.Menu());

        }
    }
}
