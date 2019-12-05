using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Eni.Xamarin.Services;
using Eni.Xamarin.Model;
using Eni.Xamarin.Forms.ViewModels;

namespace Eni.Xamarin.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientsPage : ContentPage
    {
        IBanqueAsyncService ds = DependencyService.Get<IBanqueAsyncService>();

        public ObservableCollection<Client> Clients { get; set; }

        public ClientsPage()
        {
            InitializeComponent();

            Clients = ds.ReadAllAsync().Result;

            //ClientsListView.ItemsSource = Clients;
            BindingContext = Clients;

            MessagingCenter.Subscribe<ClientFormViewModel>(this, "UpdateClients", (obj) =>
            {
                 Clients = ds.ReadAllAsync().Result;
            });
            
        }

        //async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    //if (e.Item == null)
        //    //    return;

        //    //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

        //    ////Deselect Item
        //    //((ListView)sender).SelectedItem = null;
        //}

        private void AppelClicked(object sender, EventArgs e)
        {
            //if (ListeClients.SelectedItem != null)
            //{
            //    string numero = ((Client)ListeClients.SelectedItem).Tel;
            //    TelephoneService.Instance.Impl.Appel(numero);
            //}
        }
        private void Creer(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ClientFormPage());
        }

        private void Clients_Refreshing(object sender, EventArgs e)
        {
            // IsPullToRefreshEnabled = "True"
            // Refreshing = "Clients_Refreshing"
            //Clients = new ObservableCollection<Client>(ds.ReadAllAsync().Result);

            //if (! ClientsListView.IsRefreshing)
            //{
            //}
        }
    }
}
