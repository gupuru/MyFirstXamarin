using System;
using MyFirstXamarin;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;

namespace MyFirstXamarin
{
	public class EmptyClass
	{

		private readonly RestClient client;

		public EmptyClass()
		{
			
			client = new RestClient("http://www.apple.com/jp/");

		}

		public async Task<string> GetDirections()
		{
			var request = new RestRequest("/", Method.GET);
			var response = await client.Execute<string>(request);
			var data = response.Data;
			return data;
		}

	}
}

