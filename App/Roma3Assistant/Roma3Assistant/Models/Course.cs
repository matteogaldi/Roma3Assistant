using System;
namespace Roma3Assistant.Models
{
    public class Course
    {
        public string Name { get; set; }
        public int Partition { get; set; }
        public string Teacher { get; set; }
        public int Cfu { get; set; }
        public int Code { get; set; }
        public string Id { get; set; }
        public Teacher Teachers { get; set; }

        public override string ToString()
        {
            return $"{Name} {Teachers.Name}";
        }
    }
}
