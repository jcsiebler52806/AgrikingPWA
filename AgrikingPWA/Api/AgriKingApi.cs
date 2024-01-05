using System.Text;
//using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;
using SQLite;

namespace AgriKingApp.Api
{
    internal class AgriKingApi
    {
        internal static async Task<string> Get(string apiUrl)
        {
            //bool online = true;
            string responseContent = null;
            string fullApiUrl = GetApiBaseUrl() + apiUrl;
            SQLiteAsyncConnection localCache = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);

            //Attempt to retrieve the response from the API
            try
            {
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(fullApiUrl, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                responseContent = await response.Content.ReadAsStringAsync() != string.Empty ? await response.Content.ReadAsStringAsync() : null;
            }
            catch (Exception ex)
            {
                _ = ex;
                return null;
            }

            return responseContent;
        }

        internal static async Task<string> Post(string apiUrl, object o)
        {
            var jsonObject = JsonConvert.SerializeObject(o);
            StringContent content = new StringContent(jsonObject, Encoding.UTF8, "application/json");

            HttpClient httpClient = new HttpClient();
            using HttpResponseMessage response = await httpClient.PostAsync(GetApiBaseUrl() + apiUrl, content).ConfigureAwait(false);

            return await response.Content.ReadAsStringAsync();
        }

        private static string GetApiBaseUrl()
        {
            string baseUrl = "https://web.agriking.com:8443";
            #if DEBUG
                //baseUrl = baseUrl.Replace("8443", "8843");
                baseUrl = "http://localhost:50181";
            #endif

            return baseUrl;
        }
    }
}
