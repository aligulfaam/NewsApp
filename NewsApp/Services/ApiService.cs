using NewsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.services
{
    public class ApiService
    {
        public async Task<Root> GetNews(string categoryName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=e34373806e0fa18d4f7ff1f59502a18d&topic="+categoryName.ToLower());

            //deserialization
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
