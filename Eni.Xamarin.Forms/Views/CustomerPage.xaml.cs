using Eni.Xamarin.Forms.ViewModels;
using Eni.Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eni.Xamarin.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomerPage : ContentPage
    {
        public CustomerPage(Client client)
        {
            InitializeComponent();

            BindingContext = new CustomerViewModel(this, client);
        }
    }
}