using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Roma3Assistant.Services.Event;

namespace Roma3Assistant
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewEvent : ContentPage
    {
        BindingClass nuovo_evento;
        string name;
        string description;
        DateTime data;
        public NewEvent(BindingClass nuovo)
        {
            InitializeComponent();
            nuovo_evento = nuovo;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.name = NameInput.Text;
            this.description = DescriptionInput.Text;
            nuovo_evento.AggiungiEvento(this.data, this.name, this.description);
            Navigation.PopAsync();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            data = DatePicker.Date;
        }
    }
}