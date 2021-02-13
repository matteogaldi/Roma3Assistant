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
    public partial class PaginaUtente : ContentPage
    {
        public PaginaUtente()
        {
            InitializeComponent();
            //BindingContext = new PaginaUtenteViewModel(Navigation);
        }

        private void logout_Clicked(object sender, EventArgs e)
        {

        }
    }
}