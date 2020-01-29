using System;
using System.Collections.Generic;
using Gallery.Models;

using Xamarin.Forms;

namespace Gallery
{
    public partial class MainPage : ContentPage
    {
        public MainPage(Option option)
        {
            if (option == null)
                throw new ArgumentException();

            BindingContext = option;

            InitializeComponent();
        }
    }
}
