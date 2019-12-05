using Eni.Xamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eni.Xamarin.Forms.ViewModels
{
    class ClientFormViewModel : BaseViewModel
    {

        public Client Client { get; set; }
        public Command CreateClient { get; set; }

        public ClientFormViewModel()
        {
            Title = "Nouveau Client";
            Client = new Client();

            CreateClient = new Command( async () => {
                await DataStore.CreateAsync(Client);
                MessagingCenter.Send(this, "UpdateClients");
            });
        }


    }
}
