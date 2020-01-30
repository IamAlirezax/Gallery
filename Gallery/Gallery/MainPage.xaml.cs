using System;
using System.Collections.Generic;
using Gallery.Models;

using Xamarin.Forms;

namespace Gallery
{
    public partial class MainPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {



            await Navigation.PushAsync(new MyListViewPage());

        }

        private Option option;

        public MainPage(Option option)
        {
            if (option == null)
                throw new ArgumentException();

            BindingContext = option;

            InitializeComponent();
        }

    //    public MainPage(Option option)
    //    {
    //        this.option = option;
    //    }
    }
}

