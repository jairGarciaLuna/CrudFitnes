using CrudFitnes.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrudFitnes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PersonaPage());
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
