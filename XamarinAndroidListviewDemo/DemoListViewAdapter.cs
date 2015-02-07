using System;
using Android.Widget;
using System.Collections.Generic;
using Android.App;

namespace XamarinAndroidListviewDemo
{
	public class DemoListViewAdapter : BaseAdapter
	{
		List<string> texts;
		List<int> images;
		Activity context;

		public DemoListViewAdapter (Activity context, List<string> texts, List<int> images)
		{
			this.context = context;
			this.texts = texts;
			this.images = images;
		}


		#region implemented abstract members of BaseAdapter
		public override Java.Lang.Object GetItem (int position)
		{
			return position;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override Android.Views.View GetView (int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			var view = convertView;

			if (convertView == null)
				view = context.LayoutInflater.Inflate (Resource.Layout.demo_item, null);

			// Populate the list item
			var textView = view.FindViewById<TextView> (Resource.Id.demoTextView);
			var imageView = view.FindViewById<ImageView> (Resource.Id.demoImageView);

			textView.Text = texts[position];
			imageView.SetImageResource(images[position]);

			return view;
		}

		public override int Count {
			get {
				return texts.Count;
			}
		}
		#endregion
	}
}

