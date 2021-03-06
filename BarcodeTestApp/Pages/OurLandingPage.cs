﻿using System;
using Xamarin.Forms;
namespace BarcodeTestApp
{
	public class OurLandingPage : ContentPage
	{
		public OurLandingPage()
		{
			var image = new Image();
			var pathLabel = new Label();
			var button = new Button { Text = "Take Picture", };

			Content = new StackLayout
			{
				Children =
				{
					image,
					pathLabel,
					button
				}
			};

			//Created Bindings here
			image.SetBinding(Image.SourceProperty, "LocalImageSource");
			pathLabel.SetBinding(Label.TextProperty, "Path");
			button.SetBinding(Button.CommandProperty, "TakePhotoCommand");

			BindingContext = new BaseViewModel();
		}
	}
}
