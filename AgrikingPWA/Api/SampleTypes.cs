using Newtonsoft.Json;
using AgriKingApp.Models;

namespace AgriKingApp.Api
{
    public class SampleTypes
    {
        public static SampleType GetSampleType(string sampleTypeId)
        {
            Task<string> get = AgriKingApi.Get("/api/SampleTypes/GetSampleType?sampleTypeId=" + sampleTypeId);
            string result = get.GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<SampleType>(result);
        }

        public static XrayCalibrationCategory GetXrayCalibrationCategory(string xRayCalibrationCategoryId)
        {
            Task<string> get = AgriKingApi.Get("/api/SampleTypes/GetXrayCalibrationCategory?xRayCalibrationCategoryId=" + xRayCalibrationCategoryId);
            string result = get.GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<XrayCalibrationCategory>(result);
        }
    }
}
