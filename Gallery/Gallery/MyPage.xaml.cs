using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Gallery
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new IntroductionPage());
        }
    }
}
