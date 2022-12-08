using MobileProjectPratic.ConsumingWebService;
using MobileProjectPratic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileProjectPratic.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PesqCliente : ContentPage
    {
        Clientes clientesResult = new Clientes();
        int pagina = 0;
        ViewCell lastCell;

        public PesqCliente()
        {
            InitializeComponent();
            BindingContext = new WebServiceAPI();
        }
        private async void BtnPesquisar_Clicked(object sender, EventArgs e)
        {
            WebServiceAPI client = new WebServiceAPI();
            var result = await client.Get<Clientes>("http://111.111.1.111:1111/api/ClientesAPI?itemsPorPagina=20&pagina=0&ca=95102RLPS=Q@)!lfwv.za");

            ListViewClientes.ItemsSource = result.cliente;
            BtnAvancar.IsVisible = true;
            BtnVoltar.IsVisible = false;
            BtnLimpar.IsVisible = true;
        }

        private async void Pagenation_Clicked(object sender, EventArgs e)
        {
            WebServiceAPI client = new WebServiceAPI();
            Clientes clien = new Clientes();

            pagina++;
            clien.pagina = pagina;
            var paginacao = await client.Get<Clientes>($"http://111.111.1.111:1111/api/ClientesAPI?itemsPorPagina=20&pagina={clien.pagina}&ca=95102RLPS=Q@)!lfwv.za");
            ListViewClientes.ItemsSource = paginacao.cliente;
            BtnVoltar.IsVisible = true;

        }

        private async void BtnVoltar_Clicked(object sender, EventArgs e)
        {
            WebServiceAPI client = new WebServiceAPI();
            Clientes clien = new Clientes();
            pagina--;
            clien.pagina = pagina;

            if (clien.pagina < 0)
            {
                BtnVoltar.IsVisible = false;
            }
            else
            {
                var paginacao = await client.Get<Clientes>($"http://111.111.1.111:1111/api/ClientesAPI?itemsPorPagina=20&pagina={clien.pagina}&ca=95102RLPS=Q@)!lfwv.za");
                ListViewClientes.ItemsSource = paginacao.cliente;

            }


        }

        private async void BtnAdicionarCli_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarCli());
            ListViewClientes.ItemsSource = default;
            BtnAvancar.IsVisible = false;
            BtnVoltar.IsVisible = false;
            BtnLimpar.IsVisible = false;
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.LightBlue;
                lastCell = viewCell;
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SearchCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnAvancar_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            ListViewClientes.ItemsSource = default;
            BtnAvancar.IsVisible = false;
            BtnVoltar.IsVisible = false;
            BtnLimpar.IsVisible = false;
        }

    }
}