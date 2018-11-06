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
	public partial class StepCounterPage : ContentPage
	{
		public StepCounterPage ()
		{
			InitializeComponent ();

            Label descriptionLabel = new Label
            {
                Text = "your steps today",
                FontSize = 25,
                TextColor = Color.FromHex("#6697c1"),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label stepCounterLabel = new Label
            {
                Text = "7528",
                FontSize = 125,
                TextColor = Color.FromHex("#6697c1"),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            Button viewGraphButton = new Button
            {
                Text = "View Progress",
                BackgroundColor = Color.FromHex("#6697c1"),
                BorderColor = Color.White,
                TextColor = Color.White,
                CornerRadius = 10,
                BorderWidth = 1,
                WidthRequest = 200,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            viewGraphButton.Pressed += viewGraphButtonPressed;

            Content = new StackLayout
            {
                Children = { descriptionLabel, stepCounterLabel, viewGraphButton },
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.White
            };
        }

        async void viewGraphButtonPressed(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new StepCounterGraphPage());
        }
	}
}