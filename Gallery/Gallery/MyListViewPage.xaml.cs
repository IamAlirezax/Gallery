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
                 new Exibition {Name = "Forbidden Fruit", Date = 2013 , ImageUrl="https://galleryandmore.eu/____impro/1/onewebmedia/image1.png?etag=%22fc6DlXDjG8r8t1%2FcoUf181TRBSI%22&sourceContentType=image%2Fpng"  , Place = "Gothenburg, Sweden" ,Gallery = "Gallery & More", Info ="Född 1985 i Tehran, Iran.  Studier vid Universitet i Tehran. Använder sig utav olika tekniker och material i sin glaskonst såväl som sina målningar och mosaikkonst. Har arbetat som konstlärare i Tehran där hon även har haft ett flertal utställningar. Flyttade till Göteborg för fem månader sedan där hon har hunnit göra klart en hel samling glaskonst och ha sin första utställning på Gallery & More." },
                 new Exibition {Name = "NEW FACES, IRAN", Date = 2010 , ImageUrl="http://www.artlicks.com/files/2379/600px_marjan-jabinpishe.jpg"  , Place = "London, England" ,Gallery = "Janet Rady Fine Art", Info = "All of these nine artists were previously nominated for the Un Habitat Prize in 2009, these artists are reunited in a tightly curated show which serves to illustrate the depth of artistic skill in Iran today.Nastaran Afshar, Neda Moin Afshari, Mohammad Alizadeh Bakhshayesh, Farokh Mahdavi, Elham Parsian, Javid Ramezani, Farnaz Shoar, Marjan Jabinpisheh, Mohammad Hassan Morshedzadeh But this is not just another clichéd exhibition about Iran. Through a variety of figural representations, the artists use their paints to boldly express universal sensibilities of being. Executed in richly mixed hues, these compelling images play on the subconscious with a dreamlike elusiveness and ambiguity. Throughout the exhibition, the viewer is confronted by selflessly gaunt figures staring out of the canvas, whilst others, haunted by the undefined anxiety of memory, scream silently, unaware of our gaze."},
                 new Exibition {Name = "En annan blick över tiden", Date = 2019 , ImageUrl="https://d6jf7ok6u1qis.cloudfront.net/imengine/image.php?uuid=37703dbf-c6cd-5cfe-b8f2-406316533a6a&type=preview&source=false&function=cropresize&width=960&height=480&q=75&x=0.0&y=0.18025&crop_w=1.0&crop_h=0.75&z=1"  , Place = "Bollebygd, Sweden" , Gallery = "Boy Konsthall", Info = "Marjan Jabinpishe är ursprungligen från Teheran, Iran men bor och är nu verksam i Göteborg sedan sex år tillbaka. Hon har en kandidatexamen i fri konst från Azad University Of Tehran där hon bland annat studerade olika tekniker inom måleri, mosaikkonst och glasmåleri. Hon har tidigare medverkat i grupputställningar runt om i Iran, England och i Sverige. I sina målningar utgår Marjan från sina känslor kopplade till samhället och relationen mellan människorna som befinner sig där. Färg, och då framför allt huvudfärger, används metaforiskt i Marjans målningar.Utställningen En annan blick över tiden består av 10 målningar i blandad teknik, akryl och kollage. På Boy konsthall kan du nu se ett urval av dessa målningar som aldrig tidigare visats i Sverige. Marjan har undersökt sin tanke om att varje människa försöker hitta ett inre lugn och ett harmoniskt liv. Att alla människors inre är likt varandras, men att samhället gör att vi blir splittrade och därför lever olika."},


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
