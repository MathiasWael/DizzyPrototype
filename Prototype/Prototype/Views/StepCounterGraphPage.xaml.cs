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
	public partial class StepCounterGraphPage : ContentPage
	{
		public StepCounterGraphPage ()
		{
			InitializeComponent ();

            Image graph = new Image
            {
                Source= "StepGraph4.png",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
            };

            Content = new StackLayout
            {
                Children = { graph },
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.White
            };
        }
	}
}