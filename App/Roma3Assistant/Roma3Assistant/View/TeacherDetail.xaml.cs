using Xamarin.Forms;
using Roma3Assistant.Models;
using System.Collections.Generic;

namespace Roma3Assistant.View
{
    public partial class TeacherDetail : ContentPage
    {
        public Teacher Teacher { get; private set; }
        public TeacherDetail(Teacher _teacher)
        {
            InitializeComponent();
            Teacher = _teacher;
            BindingContext = this;
        }
    }
}
