﻿using Plugin.Media;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ImageCropSample {
    public partial class App {
        public App() {
            InitializeComponent();

            MainPage = new MainPage();
            CrossMedia.Current.Initialize();
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
