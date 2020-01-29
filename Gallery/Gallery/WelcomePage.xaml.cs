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
                    new Option { title = "GlasArt" },
                    new Option { title = "Exibitions" },
                    new Option { title = "Biography" },
                    new Option { title = "Contact" }

                };

                if (string.IsNullOrWhiteSpace(searchText))
                    return options;

                return options.Where(c => c.title.StartsWith(searchText, StringComparison.Ordinal));
            }

            public WelcomePage ()

                {
           
               InitializeComponent();
               FirstList.ItemsSource = GetOptions();

                 


                }
            }
        
        }
    
