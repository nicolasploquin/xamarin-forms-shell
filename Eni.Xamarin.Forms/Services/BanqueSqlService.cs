using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using SQLite;
using Eni.Xamarin.Services;
using Eni.Xamarin.Models;

namespace Eni.Banque.Android.Services
{
    public class BanqueSqlService : IBanqueAsyncService
    {
        private static BanqueSqlService instance = null;
        public static BanqueSqlService Instance
        {
            get
            {
                if (instance == null)
                    instance = new BanqueSqlService();
                return instance;
            }
        }

        private SQLiteAsyncConnection cnx;

        private readonly string filename = "BanqueDB.db3";

        public BanqueSqlService()
        {
            var path = Path.Combine(FileSystem.AppDataDirectory, filename); 

            cnx = new SQLiteAsyncConnection(path);

            // Création de la table ClientData si nécessaire 
            //cnx.CreateTableAsync<ClientData>();
            cnx.CreateTableAsync<Client>();
            
        }

        public Task CreateAsync(Client client)
        {
            //cnx.InsertAsync(ClientData.From(client));
            cnx.InsertAsync(client);

            return Task.CompletedTask;
        }

        public Task<Client> ReadAsync(long id)
        {
            //return ClientData.To(await cnx.GetAsync<ClientData>(id));
            return cnx.GetAsync<Client>(id);
        }

        public Task<List<Client>> ReadAllAsync()
        {
            //return 
            //   ( await cnx.Table<ClientData>()
            //       .OrderBy(cli => cli.Nom)
            //       .ToListAsync() )
            //       .Select(cli => ClientData.To(cli))
            //       .ToList<Client>();
            return cnx.Table<Client>()
                    .OrderBy(cli => cli.Nom)
                    .ToListAsync();
           
        }

    }
}