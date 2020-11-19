using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Roma3Assistant
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssistenzaPage : ContentPage
    {
        public AssistenzaPage()
        {
            InitializeComponent();
        }

        private async void Invia_Clicked(object sender, EventArgs e)
        {
            await Email.ComposeAsync(oggetto.Text, testo.Text, "mail nostra");
        }
    }
}