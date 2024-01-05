using Newtonsoft.Json;
using AgriKingApp.Models;

namespace AgriKingApp.Api
{
    public class SampleCategories
    {
        public static SampleCategory GetSampleCategory(string categoryId)
        {
            Task<string> get = AgriKingApi.Get("/api/SampleCategories/GetSampleCategory?categoryId=" + categoryId);
            string result = get.GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<SampleCategory>(result);
        }
    }
}
