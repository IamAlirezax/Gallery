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
    public partial class WelcomePage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {



            await Navigation.PushAsync(new MyListViewPage());

        }



        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
            {
                if (e.SelectedItem == null)
                   return;

               var option = e.SelectedItem as Option;
                await Navigation.PushAsync(new MainPage(option));
               FirstList.SelectedItem = null;
            }








            IEnumerable<Option> GetOptions(string searchText = null)
            {
                var options = new List<Option>
                {
                    new Option { Title = "GlasArt" , ImageUrl = "https://galleryandmore.eu/____impro/1/onewebmedia/image2.png?etag=%22%2F%2BHOcRIDGNNEK%2FuKuaML7aeVno8%22&sourceContentType=image%2Fpng"},
                    new Option { Title = "Exibitions" , ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRjnb-GR9D7a0pXP0fMGgaLxaa26QGsWctwi-s1bclv7Kje35On"},
                    new Option { Title = "Biography" , ImageUrl = "https://galleryandmore.eu/____impro/1/onewebmedia/Marjan_Jabinpishe_Bio-1.jpg?etag=%22Od3LNQvsYkuw3At%2FjQYIOjUFgog%22&sourceContentType=image%2Fjpeg&ignoreAspectRatio&resize=320%2B494&extract=2%2B3%2B316%2B488&quality=85" , Info="Född 1985 i Tehran, Iran.  Studier vid Universitet i Tehran. Använder sig utav olika tekniker och material i sin glaskonst såväl som sina målningar och mosaikkonst. Har arbetat som konstlärare i Tehran där hon även har haft ett flertal utställningar. Flyttade till Göteborg för fem månader sedan där hon har hunnit göra klart en hel samling glaskonst och ha sin första utställning på Gallery & More." },
                    new Option { Title = "Contact" , Info= "Mjabinpishe@yahoo.se      +46707329249 " }

                };

                if (string.IsNullOrWhiteSpace(searchText))
                    return options;

                return options.Where(c => c.Title.StartsWith(searchText, StringComparison.Ordinal));
            }

            public WelcomePage ()

                {
           
               InitializeComponent();
               FirstList.ItemsSource = GetOptions();

                 


                }
            }
        
        }
    
