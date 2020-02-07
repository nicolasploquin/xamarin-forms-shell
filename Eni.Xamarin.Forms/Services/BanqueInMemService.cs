using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Eni.Xamarin.Models;

namespace Eni.Xamarin.Services
{
    public class BanqueInMemService : IBanqueAsyncService
    {
        private static long _id = 0L;

        private ObservableCollection<Client> clients;

        public BanqueInMemService() {
            clients = new ObservableCollection<Client>()
            {
                new Client(){ Id=_id++, Nom="Durand", Prenom="Marie", Tel="0612345789" },
                new Client(){ Id=_id++, Nom="Leblanc", Prenom="Marc", Tel="0623457891" },
                new Client(){ Id=_id++, Nom="Troadec", Prenom="Nolwenn", Tel="0634578912" },
                new Client(){ Id=_id++, Nom="Grenier", Prenom="Laurent", Tel="0645789123" },
                new Client(){ Id=_id++, Nom="Tugdual", Prenom="Lou-Ann", Tel="0657891234" }
            };


            //for (int i = 0; i < 10; i++)
            //{
            //    clients.Add(new Client()
            //    {
            //        Id = _id++,
            //        Nom = clients[i%5].Nom,
            //        Prenom = clients[i / 5].Prenom,
            //        Tel = "0612345789"
            //    });
            //}

        }




        private void Create(Client client)
        {
            if (client.Id == 0L) client.Id = _id++;
            else clients.Remove(client);
            clients.Add(client);
        }

        private Client Read(long id)
        {
            return new List<Client>(clients).Find(cli => cli.Id == id);
        }

        private ObservableCollection<Client> ReadAll()
        {
            return clients;
        }
        public Task<ObservableCollection<Client>> ReadAllAsync()
        {
            return Task.FromResult(ReadAll());
        }

        public Task<Client> ReadAsync(long id)
        {
            return Task.FromResult(Read(id));
        }

        public Task CreateAsync(Client client)
        {
            Create(client);
            return Task.CompletedTask;
        }
    }
}