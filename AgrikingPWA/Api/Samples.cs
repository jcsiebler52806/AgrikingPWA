using Newtonsoft.Json;
using AgriKingApp.Models;

namespace AgriKingApp.Api
{
    public class Samples
    {
        public static List<Sample> GetSampleMatches(string userId, string searchValue, string searchFilter, string sortValue = "numeric")
        {
            Task<string> get = AgriKingApi.Get("/api/Samples/GetSampleMatches?userId=" + userId + "&searchValue=" + searchValue + "&sortValue=" + sortValue);
            string result = get.GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<List<Sample>>(result);
        }
    }
}
