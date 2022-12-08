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
    public partial class CadastrarCli : ContentPage
    {
        public EmpresaResponse clientes = new EmpresaResponse();
        public CnpjApiService api;

        public CadastrarCli()
        {
            InitializeComponent();
            api = new CnpjApiService();
        }

        private async void CNPJ_Unfocused(object sender, FocusEventArgs e)
        {
            clientes = await api.GetCNPJ(CNPJ.Text);
            if (string.IsNullOrWhiteSpace(CNPJ.Text))
            {
                return;
            }
            else
            {
                Nome.Text = clientes.Nome;
                Fantasia.Text = clientes.Fantasia;
                Logradouro.Text = clientes.Logradouro;
                Numero.Text = clientes.Numero;
                Complemento.Text = clientes.Complemento;
                Cep.Text = clientes.Cep;
                Bairro.Text = clientes.Bairro;
                Municipio.Text = clientes.Municipio;
                Uf.Text = clientes.Uf;
                Nome_Rep_Legal.Text = clientes.Nome_Rep_Legal;
                Email.Text = clientes.Email;
                Telefone.Text = clientes.Telefone;

                BtnCadastrar.IsEnabled = true;
            }

        }

        private void BtnCadastrar_Clicked(object sender, EventArgs e)
        {
        }

    }
}