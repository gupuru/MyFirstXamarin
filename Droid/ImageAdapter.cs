
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using FFImageLoading;

namespace MyFirstXamarin.Droid
{
	public class ImageAdapter : RecyclerView.Adapter
	{

		public event EventHandler<int> ItemClick;

		public List<People> mPeoples;

		public ImageAdapter(List<People> Peoples)
		{
			mPeoples = Peoples;
		}

		public override RecyclerView.ViewHolder
			OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			// Inflate the CardView for the photo:
			View itemView = LayoutInflater.From(parent.Context).
			                              Inflate(Resource.Layout.ImageCardView, parent, false);

			// Create a ViewHolder to find and hold these view references, and 
			// register OnClick with the view holder:
			ImageViewHolder vh = new ImageViewHolder(itemView, OnClick);
			return vh;
		}

		public override int ItemCount
		{
			get
			{
				return mPeoples != null ? mPeoples.Count : 0;
			}
		}

		public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
		{
			ImageViewHolder vh = holder as ImageViewHolder;

			ImageService.Instance.LoadUrl(mPeoples[position].ProfileImage)
			   .Retry(3, 200)
			   .DownSample(100, 100)
			   .Into(vh.Image);

			vh.Text.Text = mPeoples[position].Name;

		}

		void OnClick(int position)
		{
			if (ItemClick != null)
				ItemClick(this, position);
		}
	}
}

