using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lab09AppMulti.Services;
using Lab09AppMulti.Views;

namespace Lab09AppMulti
{
    public partial class App : Application
    {
        public static float ScreenHeight { get; set; }
        public static float ScreenWidth { get; set; }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
