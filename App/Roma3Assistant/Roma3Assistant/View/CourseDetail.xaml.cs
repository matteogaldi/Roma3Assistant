using System;
using System.Collections.Generic;
using Roma3Assistant.Models;

using Xamarin.Forms;

namespace Roma3Assistant.View
{
    public partial class CourseDetail : ContentPage
    {
        public Course Course { get; private set; }
        public Teacher Teacher { get; private set; }
        public CourseDetail(Course course)
        {
            InitializeComponent();
            Course = course;
            Teacher = course.TeacherInfo;
            BindingContext = this;
        }



        void TeacherName_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TeacherDetail(Teacher));
        }

        void Link_Clicked(object sender, EventArgs e)
        {
            if (Course.Notes != null)
            {
                Navigation.PushAsync(new WebView(Course.Notes));
            }
            else
            {
                DisplayAlert("Ooops!", "Non ci sono appunti disponibili per questo corso", "Chiudi");
            }
        }

        void exams_Clicked(System.Object sender, System.EventArgs e)
        {
            if (Course.Exams != null)
            {
                Navigation.PushAsync(new WebView(Course.Notes));
            }
            else
            {
                DisplayAlert("Ooops!", "Non ci sono appunti disponibili per questo corso", "Chiudi");
            }
        }

        void lessons_Clicked(System.Object sender, System.EventArgs e)
        {
            if (Course.Stream != null)
            {
                Navigation.PushAsync(new WebView(Course.Notes));
            }
            else
            {
                DisplayAlert("Ooops!", "Non ci sono appunti disponibili per questo corso", "Chiudi");
            }
        }

        void website_Clicked(System.Object sender, System.EventArgs e)
        {
            if (Course.Website != null)
            {
                Navigation.PushAsync(new WebView(Course.Notes));
            }
            else
            {
                DisplayAlert("Ooops!", "Non ci sono appunti disponibili per questo corso", "Chiudi");
            }
        }
    }
}
