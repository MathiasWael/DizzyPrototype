using System;
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
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            Entry passwordEntry = new Entry
            {
                Placeholder = "Password",
                IsPassword = true,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
            };

            Button loginButton = new Button
            {
                Text = "Login",
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
                BackgroundColor = Color.White
            };
        }
	}
}