using System;
using System.Collections.Generic;
using Gallery.Models;

using Xamarin.Forms;

namespace Gallery
{
    public partial class MainPage : ContentPage
    {
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

