using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using OakbrookMVC.Models;

namespace OakbrookMVC
{
    public class Result
    {
        public string DecisionResult { get; set; }
    }
    public static class CallAPI
    {
        static HttpClient client = new HttpClient();
        static string uri = "http://dummydecisionengine.azurewebsites.net/decision";
        public static async Task<Result> CreateUserAsync(User user)
        {
            Result result = null;
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    new Uri(uri), user);
                response.EnsureSuccessStatusCode();
                result = await response.Content.ReadAsAsync<Result>();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}