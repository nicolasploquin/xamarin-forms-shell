using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Eni.Xamarin.Services;
using Eni.Xamarin.Models;
using Eni.Xamarin.Forms.ViewModels;

namespace Eni.Xamarin.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientsPage : ContentPage
    { 

        public ClientsPage()
        {
            InitializeComponent();
            BindingContext = new ClientsViewModel();
        }

        

        
    }
}
