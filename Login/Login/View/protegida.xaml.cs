using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Login.Model;

namespace Login.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class protegida : ContentPage
    {
        
        public protegida()
        {
            InitializeComponent();

            Set_Boas_Vindas();

           
        }

        private void Set_Boas_Vindas()
        {
            string email_login = Application.Current.Properties["usuario_logado"].ToString();

            Dados usuario_logado = App.list_usuarios.FirstOrDefault(i => i.Email == email_login);

            string nome = usuario_logado.Nome;

            lbl_boasvindas.Text = $"Bem-vindo (a): {nome}" ;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                bool confirm = await DisplayAlert("Tem certeza?", "Desconectar sua conta?", "Sim", "Não");

                if (confirm)
                {
                    App.Current.Properties.Remove("usuario_logado");
                    App.Current.MainPage = new login();
                }
            }catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }

        }
    }
}