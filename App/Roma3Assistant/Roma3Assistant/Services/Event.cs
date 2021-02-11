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

            public EventCollection Events { get; set; } = new EventCollection
            {
                [DateTime.Now] = new List<EventModel>
                    {
                        new EventModel { Name = "Bella pe te ", Description = "Te posso canta na canzone" }
                    }
            };
        }
    }
}
