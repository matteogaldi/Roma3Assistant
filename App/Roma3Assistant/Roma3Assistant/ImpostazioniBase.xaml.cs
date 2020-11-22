using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Roma3Assistant
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImpostazioniBase : ContentPage
    {

        private PaginaUtente paginaUtente;

        public ImpostazioniBase()
        {
            InitializeComponent();
            paginaUtente = new PaginaUtente();
        }

        private void profiloUtente_Clicked(object sender, EventArgs e)
        {
            profiloUtente.Navigation.PushAsync(paginaUtente);
        }

        private void security_Clicked(object sender, EventArgs e)
        {

        }

        private void credits_Clicked(object sender, EventArgs e)
        {
            credits.Navigation.PushAsync(new CreditsPage());
        }

        private void assistenza_Clicked(object sender, EventArgs e)
        {

        }
    }
}