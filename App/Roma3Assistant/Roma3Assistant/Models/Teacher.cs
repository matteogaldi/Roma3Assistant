using System;
using System.Collections.Generic;

namespace Roma3Assistant.Models
{
    public class Teacher
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Reception { get; set; }
        public Uri Website { get; set; }
        public List<Course> Courses { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
