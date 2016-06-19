using Android.App;
using Android.Widget;
using Android.OS;
using RestSharp;
using System.Collections.Generic;
using Android.Support.V7.Widget;

namespace MyFirstXamarin.Droid
{
	[Activity (Label = "MyFirstXamarin", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		RecyclerView mRecyclerView;
		RecyclerView.LayoutManager mLayoutManager;
		ImageAdapter mAdapter;
		List<People> mPeoples = new List<People>();

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Main);

			People people = new People();
			people.Name = "test";
			people.ProfileImage = "http://k.yimg.jp/images/top/sp2/cmn/logo-ns_d_131205.png";

			mPeoples.Add(people);

			mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
			mLayoutManager = new LinearLayoutManager(this);
			mRecyclerView.SetLayoutManager(mLayoutManager);

			mAdapter = new ImageAdapter(mPeoples);
			mAdapter.ItemClick += OnItemClick;
			mRecyclerView.SetAdapter(mAdapter);


			/*
			List<People> people = new PeopleUtil().read();
			foreach (People p in people)
			{
				Android.Util.Log.Debug("aaa", p.FirstName);
			}*/



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

		void OnItemClick(object sender, int position)
		{
			int imageNum = position + 1;
			Toast.MakeText(this, "This is Image number " + imageNum, ToastLength.Short).Show();
		}
	}
}


