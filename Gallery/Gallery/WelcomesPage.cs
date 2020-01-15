using System;

using Xamarin.Forms;

namespace Gallery
{
    public class WelcomesPage : ContentPage
    {
        public WelcomesPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

