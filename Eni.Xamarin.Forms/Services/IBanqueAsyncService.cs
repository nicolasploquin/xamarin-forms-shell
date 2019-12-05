
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Eni.Xamarin.Model;

namespace Eni.Xamarin.Services
{
    public interface IBanqueAsyncService
    {
        Task CreateAsync(Client client);
        Task<ObservableCollection<Client>> ReadAllAsync();
        Task<Client> ReadAsync(long id);

    }
}