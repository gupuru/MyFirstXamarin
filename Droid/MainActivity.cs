using Android.App;
using Android.Widget;
using Android.OS;
using RestSharp;

namespace MyFirstXamarin.Droid
{
	[Activity (Label = "MyFirstXamarin", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			Android.Util.Log.Debug("test", "持てない");

			var client = new RestClient("http://www.apple.com/jp/");
			var request = new RestRequest("/", Method.GET);
			IRestResponse response = client.Execute(request);
			Android.Util.Log.Debug("test", response.Content);

			RestSharp.Deserializers.JsonDeserializer deserial = new RestSharp.Deserializers.JsonDeserializer();
			People people = deserial.Deserialize<People>(response);
			Android.Util.Log.Debug("test", people.FirstName);

		}
	}
}


