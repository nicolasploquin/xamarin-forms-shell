
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Eni.Xamarin.Models;

namespace Eni.Xamarin.Services
{
    public interface IBanqueAsyncService
    {
        Task CreateAsync(Client client);
        Task<List<Client>> ReadAllAsync();
        Task<Client> ReadAsync(long id);

    }
}