
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Support.V4.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace Tabstest2
{
	public class PagerAdapter : FragmentStatePagerAdapter
	{
		int mNumberofTabs;


	
		public PagerAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{  	
		}

		public override int Count
		{
		get{return mNumberofTabs;}
		}

		public PagerAdapter(FragmentManager fm, int NumofTabs) : base(fm)
		{
			this.mNumberofTabs = NumofTabs;
		}



		public override Fragment GetItem(int position)
		{
			switch (position)
			{
				case 0:
					EventsFragment tab1 = new EventsFragment();
					return tab1;

				case 1:
					MembersFragment tab2 = new MembersFragment();
					return tab2;

				case 2:
					AboutFragment tab3 = new AboutFragment();
					return tab3;

				default:
					return null;
			}



		}
	}
}
