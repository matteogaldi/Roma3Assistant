using System;
namespace Roma3Assistant.Models
{
    public class Course
    {
        public string Name { get; set; }
        public int Partition { get; set; }
        public string Teacher { get; set; }
        public int cfu { get; set; }
        public int code { get; set; }
        public string id { get; set; }
        public Teacher Teachers { get; set; }

        public override string ToString()
        {
            return $"{Name} {Teachers.Name}";
        }
    }
}
