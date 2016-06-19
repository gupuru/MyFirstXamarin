
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using FFImageLoading.Views;

namespace MyFirstXamarin.Droid
{
	public class ImageViewHolder : RecyclerView.ViewHolder
	{
		public ImageViewAsync Image { get; private set; }
		public TextView Text { get; private set; }

		public ImageViewHolder(View itemView, Action<int> listener) : base(itemView)
		{
			Image = itemView.FindViewById<ImageViewAsync> (Resource.Id.imageView);
			Text = itemView.FindViewById<TextView> (Resource.Id.textView);

			itemView.Click += (sender, e) => listener(base.Position);
		}
	}
}

