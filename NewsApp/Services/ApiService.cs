using Newtonsoft.Json;
using NewsApp.Models;

namespace NewsApp.Services;

public class ApiService
{
	public async Task<Root> GetNews(string categoryName)
	{
		var httpClient = new HttpClient();	
		var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?country=tw&category={categoryName.ToLower()}&apikey=958c82076df0a05c64829de832c1f21f");
		return JsonConvert.DeserializeObject<Root>(response);
	}
}