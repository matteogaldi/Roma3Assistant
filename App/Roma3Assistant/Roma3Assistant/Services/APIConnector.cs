using RestSharp;
using Newtonsoft.Json;
using Roma3Assistant.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Roma3Assistant.Services
{
    public class APIConnector
    {
        private static string bearerToken = App.token;

        public static List<Course> GetAllCourses()
        {
            var client = new RestClient($"{Constants.API_ENDPOINT}/courses/");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            List<Course> allCourses = JsonConvert.DeserializeObject<List<Course>>(response.Content);
            return allCourses;
        }

        public static Course GetCourseByID(string courseID)
        {
            var client = new RestClient($"{Constants.API_ENDPOINT}/courses/{courseID}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {bearerToken}");
            IRestResponse response = client.Execute(request);
            Course course = JsonConvert.DeserializeObject<Course>(response.Content);
            return course;
        }

        public static List<string> GetUserSubscriptions(string userID)
        {
            var client = new RestClient($"{Constants.API_ENDPOINT}/subscriptions/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {bearerToken}");
            request.AddParameter("undefined", $"{{\n\t\"uuid\": \"{userID}\"\n}}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            List<string> subscriptions = JsonConvert.DeserializeObject<List<string>>(response.Content);
            return subscriptions;
        }

        public static string CreateNewSubscription(string userID, string courseID)
        {
            var client = new RestClient($"{Constants.API_ENDPOINT}/subscriptions/");
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {bearerToken}");
            request.AddParameter("undefined", $"{{\n\t\"studentUUID\": \"{userID}\",\n\t\"courseUUID\": \"{courseID}\"\n}}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return "";
        }

        public static Teacher GetTeacherInfoByID(string teacherID)
        {
            var client = new RestClient($"{Constants.API_ENDPOINT}/teachers/{teacherID}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {bearerToken}");
            IRestResponse response = client.Execute(request);
            Teacher teacher = JsonConvert.DeserializeObject<Teacher>(response.Content);
            return teacher;
        }

        public static TokenResponse GetToken(string userID)
        {
            var client = new RestClient($"{Constants.API_ENDPOINT}/auth/login");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", $"{{\n\t\"uuid\": \"{userID}\"\n}}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            TokenResponse tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(response.Content);
            return tokenResponse;
        }
    }
}
