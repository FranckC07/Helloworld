using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Helloworld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new RelativelayoutExercice();
            //MainPage = new AbsolutelayoutExercice1();
            //MainPage = new AbsolutelayoutExercice2();
            //MainPage = new GridExercice2();
            //MainPage = new GridExercice2();
            //MainPage = new StacklayoutExercice1();
            //MainPage = new StacklayoutExercice2();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
