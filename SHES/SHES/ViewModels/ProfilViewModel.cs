using SHES.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Plugin.Calendar.Models;

namespace SHES.ViewModels
{
    public class ProfilViewModel : BaseViewModel
    {
        public EventCollection Events { get; set; }

        public ProfilViewModel() 
        {
            Title = "Profil";


            Events = new EventCollection
            {
                [DateTime.Now] = new List<EventModel>
                {
                    new EventModel { Name = "Cool event1", Description = "This is Cool event1's description!" },
                    new EventModel { Name = "Cool event2", Description = "This is Cool event2's description!" }
                }                
            };

            Events = new EventCollection
            {
                [DateTime.Now.AddDays(3)] = new List<EventModel>
                {
                    new EventModel { Name = "Cool event1", Description = "This is Cool event1's description!" },
                    new EventModel { Name = "Cool event2", Description = "This is Cool event2's description!" }
                }
            };
        }
    }
}
