using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Helloworld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageExercice : ContentPage
    {
        public ImageExercice()
        {
            InitializeComponent();

            var imageSource = new UriImageSource { Uri = new Uri("https://s2.best-wallpaper.net/wallpaper/1920x1080/1302/Extreme-sports-mountain-bike_1920x1080.jpg") };
            imageSource.CachingEnabled = false;
            monimage.Source = imageSource;

        }
    }
}