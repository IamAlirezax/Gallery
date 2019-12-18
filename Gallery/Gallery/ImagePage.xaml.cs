using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Gallery
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
   var imageSource = new UriImageSource { Uri = new Uri("http://d6jf7ok6u1qis.cloudfront.net/imengine/image.php?uuid=37703dbf-c6cd-5cfe-b8f2-406316533a6a&type=preview&source=false&function=cropresize&width=960&height=480&q=75&x=0.0&y=0.18025&crop_w=1.0&crop_h=0.75&z=1") };
            imageSource.CachingEnabled = false;
            image.Source = imageSource;
            
            


            }
    }
}



