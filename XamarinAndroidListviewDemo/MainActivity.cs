using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace XamarinAndroidListviewDemo
{
	[Activity (Label = "XamarinAndroidListviewDemo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private ListView demoListView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Create mockup data
			List<string> texts = new List<string> ();
			List<int> images = new List<int> ();

			texts.Add ("BiColourLacing1");
			images.Add(Resource.Drawable.BiColourLacing1);

			texts.Add ("BowTieLacing1");
			images.Add(Resource.Drawable.BowTieLacing1);

			texts.Add ("BushwalkLacing1");
			images.Add(Resource.Drawable.BushwalkLacing1);

			texts.Add ("CheckerboardLacing1");
			images.Add(Resource.Drawable.CheckerboardLacing1);

			texts.Add ("CrissCrossLacing1");
			images.Add(Resource.Drawable.CrissCrossLacing1);

			texts.Add ("DisplayShoeLacing1");
			images.Add(Resource.Drawable.DisplayShoeLacing1);

			texts.Add ("DoubleBackLacing1");
			images.Add(Resource.Drawable.DoubleBackLacing1);

			texts.Add ("DoubleBackLacing2");
			images.Add(Resource.Drawable.DoubleBackLacing2);

			texts.Add ("DoubleCrossLacing1");
			images.Add(Resource.Drawable.DoubleCrossLacing1);

			texts.Add ("DoubleHelixLacing1");
			images.Add(Resource.Drawable.DoubleHelixLacing1);

			texts.Add ("DoubleLacing1");
			images.Add(Resource.Drawable.DoubleLacing1);

			texts.Add ("FootbagLacing1");
			images.Add(Resource.Drawable.FootbagLacing1);

			texts.Add ("HashLacing1");
			images.Add(Resource.Drawable.HashLacing1);

			texts.Add ("KnottedLacing1");
			images.Add(Resource.Drawable.KnottedLacing1);

			texts.Add ("KnottedSegmentLacing1");
			images.Add(Resource.Drawable.KnottedSegmentLacing1);

			demoListView = FindViewById<ListView> (Resource.Id.demoListView);
			demoListView.Adapter = new DemoListViewAdapter (this, texts, images);
		}
	}
}