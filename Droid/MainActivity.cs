using Android.App;
using Android.Widget;
using Android.OS;
using RestSharp;
using System.Collections.Generic;

namespace MyFirstXamarin.Droid
{
	[Activity (Label = "MyFirstXamarin", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			List<People> people = new PeopleUtil().read();
			foreach (People p in people)
			{
				Android.Util.Log.Debug("aaa", p.FirstName);
			}



			/*
			var client = new RestClient("https://raw.githubusercontent.com/gupuru/MyFirstXamarin/asset/data.json");
			var request = new RestRequest("/", Method.GET);
		//	IRestResponse response = client.Execute(request);

			client.ExecuteAsync(request, response =>
			{
				RestSharp.Deserializers.JsonDeserializer deserial = new RestSharp.Deserializers.JsonDeserializer();
				List<People> people = deserial.Deserialize<List<People>>(response);
				foreach (People p in people)
				{
					Android.Util.Log.Debug("test", p.FirstName);
				}

				new PeopleUtil().write(people);


			});
			*/
			/*
			RestSharp.Deserializers.JsonDeserializer deserial = new RestSharp.Deserializers.JsonDeserializer();
			List<People> people = deserial.Deserialize<List<People>>(response);

			new PeopleUtil().write(people);*/

			//foreach (People p in people)
			//{
			//	Android.Util.Log.Debug("test", p.LastName);
			//}

		}
	}
}


