using System;
using Roma3Assistant.Models;
using System.Collections.Generic;
using Roma3Assistant.Services;

using Xamarin.Forms;

namespace Roma3Assistant
{
    public partial class Corsi : ContentPage
    {
        public List<Course> courses { get; private set; }
        public Corsi()
        {
            InitializeComponent();
            courses = APIConnector.GetAllCourses();
            BindingContext = this;
        }

        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Course course = e.CurrentSelection[0] as Course;
            Navigation.PushAsync(new View.CourseDetail(course));
        }
    }
}
