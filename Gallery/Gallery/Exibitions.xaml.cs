using System;
using System.Collections.Generic;
using Gallery.Models;

using Xamarin.Forms;

namespace Gallery
{
    public partial class Exibitions : ContentPage
    {
        public Exibitions(Exibition exibition)
        {
            if (exibition == null)
                throw new ArgumentException();

            BindingContext = exibition;

            InitializeComponent();
        }
    }
}
