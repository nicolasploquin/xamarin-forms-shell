using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Eni.Xamarin.Forms.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clients(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClientsPage());
        }

        private void Button_Creer(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ClientFormPage());
        }
    }
}
