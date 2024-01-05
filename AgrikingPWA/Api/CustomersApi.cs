using AgriKingApp.Models;
using Newtonsoft.Json;

namespace AgriKingApp.Api
{
    public class CustomersApi
    {
        public static List<Customer> GetCustomerMatches(string userId, string searchValue = "", string sortValue = "numeric")
        {
            Task<string> get = AgriKingApi.Get("/api/Customers/GetSalespersonCustomers?userId=" + userId + "&salespersonId=9034");
            string result = get.GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<List<Customer>>(result);
        }

        public static Customer GetCustomer(string customerId)
        {
            Task<string> get = AgriKingApi.Get("/api/Customers/GetCustomer?Id=" + customerId);
            string result = get.GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<Customer>(result);
        }
    }
}
