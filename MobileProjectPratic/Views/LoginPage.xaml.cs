using MobileProjectPratic.ConsumingWebService;
using MobileProjectPratic.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileProjectPratic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        UsersCredentials usuariosResult = new UsersCredentials();

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new WebServiceAPI();
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntryCPF.Text) || string.IsNullOrWhiteSpace(EntrySenha.Text))
            {
                await DisplayAlert("Atenção", "Preencha os campos corretamente", "OK");
            }
            else
            {
                WebServiceAPI user = new WebServiceAPI();
                var result = await user.GetUser<UsersCredentials>($"http://192.168.1.115:8080/api/UserAPI?user={EntryCPF.Text}&pass={EntrySenha.Text}");

                if (result.Usuario.Count > 0)
                {
                    await DisplayAlert("Sucesso", "Login realizado com sucesso", "Ok");
                    await Navigation.PushAsync(new MenuPrincipal());
                }
                else
                {
                    await DisplayAlert("Atenção", "Usuário ou Senha incorretos", "OK");
                }


                //foreach (var item in result.Usuario)
                //{
                //    if (item.Cpf != EntryCPF.Text && item.Password != EntrySenha.Text)
                //    {
                //        await DisplayAlert("Atenção", "Usuário ou Senha incorretos", "OK");
                //    }
                //    else
                //    {
                //        await DisplayAlert("Sucesso", "Login realizado com sucesso", "Ok");
                //        await Navigation.PushAsync(new MenuPrincipal());
                //    }
                //}

            }
        }
        private void BtnSignUp_Clicked(object sender, EventArgs e)
        {

        }
    }
}