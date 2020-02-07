using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Eni.Xamarin.Forms.ViewModels;
using Eni.Xamarin.Models;
using Eni.Xamarin.Services;

namespace Eni.Xamarin.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientFormPage : ContentPage
    {
        IBanqueAsyncService ds = DependencyService.Get<IBanqueAsyncService>();
        public ClientFormPage()
        {
            InitializeComponent();
            BindingContext = new ClientFormViewModel(this);
        }
        public ClientFormPage(Client client) : this()
        {
            ClientFormViewModel vm = (ClientFormViewModel) BindingContext;
            vm.Client = client;
            vm.Title = "Modifier";
        }

        //private void Enregistrer(object sender, EventArgs e)
        //{
        //    //vm.CreateClientCommand.E(Client);
        //    Navigation.PopModalAsync();
        //}
    }
}