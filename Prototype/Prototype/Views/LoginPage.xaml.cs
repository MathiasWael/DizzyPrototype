﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();

            Entry usernameEntry = new Entry
            {
                Placeholder = "Username",
                WidthRequest = 400,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            Entry passwordEntry = new Entry
            {
                Placeholder = "Password",
                WidthRequest = 400,
                IsPassword = true,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
            };

            Button loginButton = new Button
            {
                Text = "Login",
                BackgroundColor = Color.FromHex(App.Blue),
                TextColor = Color.White,
                CornerRadius = 10,
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
            };

            loginButton.Pressed += (sender, args) =>
            {
                Navigation.PopModalAsync();
            };

            Content = new StackLayout
            {
                Children = { usernameEntry, passwordEntry, loginButton },
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.FromHex(App.Background)
            };
        }
	}
}