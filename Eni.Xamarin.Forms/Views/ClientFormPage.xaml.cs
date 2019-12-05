using Eni.Xamarin.Forms.ViewModels;
using Eni.Xamarin.Model;
using Eni.Xamarin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eni.Xamarin.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientFormPage : ContentPage
    {
        IBanqueAsyncService ds = DependencyService.Get<IBanqueAsyncService>();

        ClientFormViewModel vm = new ClientFormViewModel();
        public ClientFormPage()
        {
            InitializeComponent();

            BindingContext = vm;
        }

        private void Enregistrer(object sender, EventArgs e)
        {
            //vm.CreateClientCommand.E(Client);
            Navigation.PopModalAsync();
        }
    }
}