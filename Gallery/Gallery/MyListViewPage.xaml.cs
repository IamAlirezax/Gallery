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


        async void Handle_Clicked(object sender, System.EventArgs e)
        {



            await Navigation.PushAsync(new WelcomePage());

        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var exibition = e.SelectedItem as Exibition;
            await Navigation.PushAsync(new Exibitions(exibition));
            MyListView.SelectedItem = null;
        }


        void Handle_TextChanged(object sender, Xamarin.Forms. TextChangedEventArgs e)
        {
            MyListView.ItemsSource = GetExibitions(e.NewTextValue);
        }

        IEnumerable<Exibition> GetExibitions(string searchText= null)
        {
            var exibitions = new List<Exibition>
            {
                 new Exibition {Name = "Forbidden Fruit", Date = 2013 , ImageUrl="https://galleryandmore.eu/____impro/1/onewebmedia/image1.png?etag=%22fc6DlXDjG8r8t1%2FcoUf181TRBSI%22&sourceContentType=image%2Fpng"  , Place = "Gothenburg, Sweden" ,Gallery = "Gallery & More"},
                 new Exibition {Name = "NEW FACES, IRAN", Date = 2010 , ImageUrl="http://www.artlicks.com/files/2379/600px_marjan-jabinpishe.jpg"  , Place = "London, England" ,Gallery = "Janet Rady Fine Art"},
                 new Exibition {Name = "En annan blick över tiden", Date = 2019 , ImageUrl="https://d6jf7ok6u1qis.cloudfront.net/imengine/image.php?uuid=37703dbf-c6cd-5cfe-b8f2-406316533a6a&type=preview&source=false&function=cropresize&width=960&height=480&q=75&x=0.0&y=0.18025&crop_w=1.0&crop_h=0.75&z=1"  , Place = "Bollebygd, Sweden" , Gallery = "Boy Konsthall"},


            };

            if (string.IsNullOrWhiteSpace(searchText))
                return exibitions;

            return exibitions.Where(c => c.Name.StartsWith(searchText, StringComparison.Ordinal));
        }
        


    public MyListViewPage()
        {
            InitializeComponent();
            MyListView.ItemsSource = GetExibitions();
          
            


        }
    }
}
