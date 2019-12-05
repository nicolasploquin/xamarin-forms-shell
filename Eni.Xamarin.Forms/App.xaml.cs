using Xamarin.Forms;

using Eni.Xamarin.Forms.Views;
using Eni.Xamarin.Services;

namespace Eni.Xamarin.Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Enregistrement du service d'accès aux données (classe d'implémentation)
            //DependencyService.Register<BanqueInMemService>();
            DependencyService.Register<BanqueRestService>();

            MainPage = new AppShell();
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
