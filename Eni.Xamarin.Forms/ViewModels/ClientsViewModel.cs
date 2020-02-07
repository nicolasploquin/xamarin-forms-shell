using Eni.Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Eni.Xamarin.Forms.ViewModels
{
    class ClientsViewModel : BaseViewModel
    {
        public ObservableCollection<Client> Clients { get; set; }

        private Client activeClient;
        public Client ActiveClient {
            get { return activeClient; }
            set { SetProperty(ref activeClient, value); }
        }


        public Command ActualiserListe { get; set; }

        public ClientsViewModel()
        {
            Title = "Clients";

            Clients = new ObservableCollection<Client>();
            //Clients = DataService.ReadAllAsync().Result;

            //DataService.ReadAllAsync().ContinueWith(
            //    clients => {
            //        Clients.Clear();
            //        foreach (Client cli in clients.Result)
            //        {
            //            Clients.Add(cli);
            //        }
            //    }
            //);

            ActualiserListe = new Command( () => {
                DataService.ReadAllAsync().ContinueWith(
                    clients =>
                    {
                        Clients.Clear();
                        foreach (Client cli in clients.Result)
                        {
                            Clients.Add(cli);
                        }
                    }
                );
            });

            ActualiserListe.Execute(null);


            MessagingCenter.Subscribe<ClientFormViewModel>(this, "UpdateClients", (sender) =>
            {
                ActualiserListe.Execute(null);
                //Clients = DataService.ReadAllAsync().Result;
            });
        }


        //private void AppelClicked(object sender, EventArgs e)
        //{
        //    //if (ListeClients.SelectedItem != null)
        //    //{
        //    //    string numero = ((Client)ListeClients.SelectedItem).Tel;
        //    //    TelephoneService.Instance.Impl.Appel(numero);
        //    //}
        //}
        //private void Creer(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new ClientFormPage());
        //}

        //private void Clients_Refreshing(object sender, EventArgs e)
        //{
        //    // IsPullToRefreshEnabled = "True"
        //    // Refreshing = "Clients_Refreshing"
        //    //Clients = new ObservableCollection<Client>(ds.ReadAllAsync().Result);

        //    //if (! ClientsListView.IsRefreshing)
        //    //{
        //    //}
        //}

        //async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    //if (e.Item == null)
        //    //    return;

        //    //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

        //    ////Deselect Item
        //    //((ListView)sender).SelectedItem = null;
        //}
    }
}
