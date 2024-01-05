
using AgriKingApp.Models;
using Newtonsoft.Json;

namespace AgriKingApp.Api
{
    public class SalesOrdersApi
    {
        public static List<SalesOrder> GetSalesOrders(string userId)
        {
            Task<string> get = AgriKingApi.Get("/api/SalesOrders/GetSalesOrders?userId=" + userId);
            string result = get.GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<List<SalesOrder>>(result);
        }

        public static SalesOrder GetSalesOrder(string salesOrderId)
        {
            Task<string> get = AgriKingApi.Get("/api/SalesOrders/GetSalesOrder?Id=" + salesOrderId);
            string result = get.GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<SalesOrder>(result);
        }
    }
}
