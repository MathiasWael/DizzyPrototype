using Prototype.ViewModels;
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
	public partial class JournalDetailPage : ContentPage
	{
        private JournalDetailViewModel _viewModel;

		public JournalDetailPage(JournalDetailViewModel viewModel)
		{
			InitializeComponent();
            BindingContext = _viewModel = viewModel;
        }
	}
}