using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Eni.Xamarin.Models;
using Xamarin.Essentials;

namespace Eni.Xamarin.Forms.ViewModels
{
    class CustomerViewModel : BaseViewModel
    {

        public Client Client { get; set; }
        public Command ActionCall { get; set; }

        public CustomerViewModel(ContentPage page, Client client)
        {
            Page = page;

            Title = "Nouveau";
            Client = client;

            ActionCall = new Command(() =>
            {
                PhoneDialer.Open(Client.Tel);
            });
        }


        //private void Enregistrer(object sender, EventArgs e)
        //{
        //    //vm.CreateClientCommand.E(Client);
        //    Navigation.PopModalAsync();
        //}

    }
}
