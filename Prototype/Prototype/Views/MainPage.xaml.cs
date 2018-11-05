using Prototype.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            LoginAsync();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.DizzinessRegister, (NavigationPage)Detail);
        }

        private async Task LoginAsync()
        {
            await Navigation.PushModalAsync(new NavigationPage(new LoginPage()));
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.DizzinessRegister:
                        MenuPages.Add(id, new NavigationPage(new DizzinessRegisterPage()));
                        break;
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.StepCounter:
                        MenuPages.Add(id, new NavigationPage(new StepCounterPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}