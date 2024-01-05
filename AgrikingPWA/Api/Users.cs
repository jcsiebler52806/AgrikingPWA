using AgriKingApp.Models;
using Newtonsoft.Json;

namespace AgriKingApp.Api
{
    public static class Users
    {
        public static User GetUser(string userId)
        {
            Task<string> get = AgriKingApi.Get("/api/Users/GetUserStatus?userId=" + userId);
            string result = get.GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<User>(result);
        }

        public static void PostNewPassword(string userId, string password)
        {
            _ = AgriKingApi.Post("/api/Users/PostNewPassword", new { UserId = userId, Password = password });
        }

        public static bool PasswordIsValid(string userId, string password)
        {
            Task<string> get = AgriKingApi.Get("/api/Users/PasswordIsValid?userId=" + userId + "&password=" + password);
            string result = get.GetAwaiter().GetResult();

            if (result != null && result != string.Empty)
            {
                return JsonConvert.DeserializeObject<bool>(result);
            }
            else
            {
                return false;
            }         
        }
    }
}