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
                    new Option { Title = "GlasArt" },
                    new Option { Title = "Exibitions" },
                    new Option { Title = "Biography" },
                    new Option { Title = "Contact" }

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
    
