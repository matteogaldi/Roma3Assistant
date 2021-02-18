using System.Collections;
using Newtonsoft.Json;
namespace Roma3Assistant.Models
{
    public class Course
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("partition")]
        public int Partition { get; set; }

        [JsonProperty("teacher")]
        public string Teacher { get; set; }

        [JsonProperty("cfu")]
        public int Cfu { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("teachers")]
        public Teacher TeacherInfo { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("exams")]
        public string Exams { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("stream")]
        public string Stream { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
