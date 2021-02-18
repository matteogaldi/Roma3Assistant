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

        private void logout_Clicked(object sender, EventArgs e)
        {
            SecureStorage.RemoveAll();
            Navigation.InsertPageBefore(new LoginPage(), this);
            Navigation.PopAsync();
        }
    

        }
    }
