using Roma3Assistant.View;
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
    public partial class ImpostazioniBase : ContentPage
    {

        public ImpostazioniBase()
        {
            InitializeComponent();
        }


        private void security_Clicked(object sender, EventArgs e)
        {
            security.Navigation.PushAsync(new Sicurezza());
        }

        private void credits_Clicked(object sender, EventArgs e)
        {
            credits.Navigation.PushAsync(new CreditsPage());
        }

        private void assistenza_Clicked(object sender, EventArgs e)
        {
            assistenza.Navigation.PushAsync(new AssistenzaPage());
        }

        private async Task logout_ClickedAsync(object sender, EventArgs e) {
            bool answer = await DisplayAlert("Sei sicuro?", "", "Si", "No");
            if (answer)
            {
                SecureStorage.RemoveAll();
                await Navigation.PushAsync(new LoginPage());
            }

        }
    }
}