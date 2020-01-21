using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Gallery.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery
{
    
    public partial class MyListViewPage : ContentPage
    {


        public MyListViewPage()
        {
            InitializeComponent();
            MyListView.ItemsSource = new List<Exibition>
            {
                new Exibition {Name = "NEW FACES, IRAN", Date = 2010 , ImageUrl="http://www.artlicks.com/files/2379/600px_marjan-jabinpishe.jpg"  , Place = "London, England" ,Gallery = "Janet Rady Fine Art"},
                new Exibition {Name = "En annan blick över tiden", Date = 2010 , ImageUrl="https://d6jf7ok6u1qis.cloudfront.net/imengine/image.php?uuid=37703dbf-c6cd-5cfe-b8f2-406316533a6a&type=preview&source=false&function=cropresize&width=960&height=480&q=75&x=0.0&y=0.18025&crop_w=1.0&crop_h=0.75&z=1"  , Place = "Bollebygd, Sweden" , Gallery = "Boy Konsthall"},

            };



        }
    }
}
