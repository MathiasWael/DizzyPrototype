using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prototype.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Prototype
{
    public partial class App : Application
    {
        public static string Blue = "#003865";
        public static string Background = "#ccd7e0";


        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
