﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Roma3Assistant
{
    public partial class Profilo : ContentPage
    {
        public Profilo()
        {
            InitializeComponent();
        }

        private void impostazioni_Clicked(object sender, EventArgs e)
        {
            impostazioni.Navigation.PushAsync(new ImpostazioniBase());
        }
    }
}
