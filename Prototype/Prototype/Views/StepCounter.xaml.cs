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
    public partial class StepCounter : ContentPage
    {
        public StepCounter()
        {
            InitializeComponent();

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

            Content = new StackLayout
            {
                Children = { descriptionLabel, stepCounterLabel },
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.White
            };
        }
    }
}