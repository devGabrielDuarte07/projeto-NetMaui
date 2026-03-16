using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace telas.Services
{
    public static class ApiService<T> where T : class
    {
		private static HttpClient client;

		public static HttpClient Client
		{
			get {
				if(client == null)
				{
					client = new HttpClient();
					client.BaseAddress = new Uri("http://10.0.2.2:5251/api/");
				}
				return client; }
		}

		public async static Task<List<T>> GetList(string url)
		{
			var response = await Client.GetAsync(url); 
			var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            var json = JsonConvert.DeserializeObject<List<T>>(content);
			return json;
		}

	}
}
