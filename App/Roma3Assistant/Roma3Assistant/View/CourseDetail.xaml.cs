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
            Navigation.PushAsync(new WebView(""));
        }

    }
}
