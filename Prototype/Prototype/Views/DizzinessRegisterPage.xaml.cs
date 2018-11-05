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
                TextColor = Color.FromHex("#6697c1"),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label dizzyLabel = new Label
            {
                Text = "5",
                FontSize = 125,
                TextColor = Color.FromHex("#6697c1"),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            Slider slider = new Slider
            {
                Maximum = 10.0f,
                Minimum = 0.0f,
                Value = 5.0f,

                MinimumTrackColor = Color.FromHex("#6697c1"),
                ThumbColor = Color.FromHex("#ccdcea"),
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
                BackgroundColor = Color.FromHex("#6697c1"),
                BorderColor = Color.White,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                CornerRadius = 10,
                BorderWidth = 1,
                WidthRequest = 200,

            };

            Content = new StackLayout
            {
                Children = { descriptionLabel, dizzyLabel, slider, registerButton },
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.White
            };
        }
	}
}