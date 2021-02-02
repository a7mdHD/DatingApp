using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationErorr(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Erorr", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Erorr");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}