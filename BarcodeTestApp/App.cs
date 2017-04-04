﻿using Xamarin.Forms;
using ZXing.Mobile;

namespace BarcodeTestApp
{
	public class App : Application
	{
		public App()
		{
			MainPage = new OurLandingPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
