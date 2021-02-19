using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Plugin.Calendar.Models;


namespace Roma3Assistant.Services
{
    public class Event
    {
        public partial class BindingClass
        {


            public EventCollection Events { get; set; } = new EventCollection
            {
                [DateTime.Now] = new List<EventModel>
                    {
                        new EventModel { Name = "Analisi I", Description = "Esame di analisi I , 9.00 , aula 11" }
                    }
            };

            public void AggiungiEvento(DateTime date, string nome, string descrizione)
            {
                Events.Add(date, new List<EventModel>
                     {
                        new EventModel{ Name= nome , Description=descrizione}
                     });
            }
        }
    }
}
