﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Eni.Xamarin.Models;
using Xamarin.Essentials;

namespace Eni.Xamarin.Forms.ViewModels
{
    class ClientFormViewModel : BaseViewModel
    {

        public Client Client { get; set; }
        public Command CreateClient { get; set; }

        public ClientFormViewModel(ContentPage page)
        {
            Page = page;

            Title = "Nouveau";
            Client = new Client();

            CreateClient = new Command(async () =>
            {
                _ = Page.Navigation.PopModalAsync();
                await DataService.CreateAsync(Client);
                Vibration.Vibrate(TimeSpan.FromMilliseconds(20));
                MessagingCenter.Send(this, "UpdateClients");
            });
        }


        //private void Enregistrer(object sender, EventArgs e)
        //{
        //    //vm.CreateClientCommand.E(Client);
        //    Navigation.PopModalAsync();
        //}

    }
}
