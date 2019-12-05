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
    public partial class AppPage : NavigationPage
    {
        public AppPage()
        {
            InitializeComponent();

            Navigation.PushAsync(new MainPage());
        }
    }
}