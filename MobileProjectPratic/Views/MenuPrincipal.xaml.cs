using MobileProjectPratic.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileProjectPratic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private async void BtnClientes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PesqCliente());
        }


        private void BtnProdutos_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnOrcamentos_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnAgenda_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnSairApp_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}