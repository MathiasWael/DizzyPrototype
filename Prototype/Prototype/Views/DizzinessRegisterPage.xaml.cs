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
	public partial class DizzinessRegisterPage : ContentPage
	{
		public DizzinessRegisterPage ()
		{
			InitializeComponent ();

            Label descriptionLabel = new Label
            {
                Text = "register your dizziness",
                FontSize = 25,
                TextColor = Color.FromHex(App.Blue),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label dizzyLabel = new Label
            {
                Text = "5",
                FontSize = 125,
                TextColor = Color.FromHex(App.Blue),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            Slider slider = new Slider
            {
                Maximum = 10.0f,
                Minimum = 0.0f,
                Value = 5.0f,

                MinimumTrackColor = Color.FromHex(App.Blue),
                ThumbColor = Color.FromHex("#143c5c"),
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            slider.ValueChanged += (sender, args) =>
            {
                slider.Value = Math.Round(args.NewValue);
                dizzyLabel.Text = slider.Value.ToString();
            };

            Button registerButton = new Button
            {
                Text = "Submit",
                BackgroundColor = Color.FromHex(App.Blue),
                BorderColor = Color.White,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                CornerRadius = 10,
                BorderWidth = 1,
                WidthRequest = 200,

            };

            Button viewGraphButton = new Button
            {
                Text = "View Progress",
                BackgroundColor = Color.FromHex(App.Blue),
                BorderColor = Color.White,
                TextColor = Color.White,
                CornerRadius = 10,
                BorderWidth = 1,
                WidthRequest = 150,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            viewGraphButton.Pressed += viewGraphButtonPressed;

            Content = new StackLayout
            {
                Children = { descriptionLabel, dizzyLabel, slider, registerButton, viewGraphButton },
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.FromHex(App.Background)
            };
        }
        async void viewGraphButtonPressed(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new DizzinessRegisterGraphPage());
        }
    }
}