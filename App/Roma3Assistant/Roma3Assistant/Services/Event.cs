using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Plugin.Calendar.Models;


namespace Roma3Assistant.Services
{
    class Event
    {
        public partial class BindingClass
        {


            public EventCollection SavedEvents { get; set; } = new EventCollection
            {
                [DateTime.Now] = new List<EventModel>
                    {
                        new EventModel { Name = "Analisi I", Description = "Esame di analisi I , 9.00 , aula 11" }
                    }
            };

           public void AggiungiEvento(int day,int month,int year,string nome,string descrizione)
            {
                SavedEvents.Add(new DateTime(year, month, day), new List<EventModel>
                {
                    new EventModel{ Name= nome , Description=descrizione}
                });
            }
        }
    }
}
