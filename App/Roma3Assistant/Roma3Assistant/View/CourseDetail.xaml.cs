using System;
using System.Collections.Generic;
using Roma3Assistant.Models;

using Xamarin.Forms;

namespace Roma3Assistant.View
{
    public partial class CourseDetail : ContentPage
    {
        Course Course;
        public CourseDetail(Course course)
        {
            InitializeComponent();
            Course = course;
            BindingContext = Course;
        }
    }
}
