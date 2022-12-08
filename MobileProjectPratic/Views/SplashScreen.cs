using MobileProjectPratic.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileProjectPratic
{
    public class SplashScreen : ContentPage
    {
        Image splashimage;

        public SplashScreen()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashimage = new Image
            {
                Source = "logoaucom.png",
                WidthRequest = 350,
                HeightRequest = 350
            };
            AbsoluteLayout.SetLayoutFlags(splashimage,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashimage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashimage);

            this.BackgroundColor = Color.FromHex("#429de3");
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashimage.ScaleTo(1, 1300); // Time-Consuming processes such as initialization
            await splashimage.ScaleTo(0.5, 1200, Easing.Linear);
            await splashimage.ScaleTo(0, 1000, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new LoginPage()); // After Loading MainPage it gets Navigated
        }

    }
}
