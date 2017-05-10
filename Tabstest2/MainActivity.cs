using Android.OS;
using Android.App;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Support.V7.Widget;


namespace Tabstest2
{
	[Activity(Label = "Tabstest2", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : AppCompatActivity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetSupportActionBar(toolbar);

			TabLayout tabLayout = FindViewById<TabLayout>(Resource.Id.tab_layout);
			tabLayout.AddTab(tabLayout.NewTab().SetText("Events"));
			tabLayout.AddTab(tabLayout.NewTab().SetText("Members"));
			tabLayout.AddTab(tabLayout.NewTab().SetText("About"));


			ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.pager);

		PagerAdapter adapter = new PagerAdapter(SupportFragmentManager, tabLayout.TabCount);

			viewPager.Adapter = adapter;
			tabLayout.SetupWithViewPager(viewPager);

		}
	}
}

