using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        App PropriedadesApp;

        public login()
        {
            InitializeComponent();
            PropriedadesApp = (App)Application.Current;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string email = txt_email.Text;
                string senha = txt_senha.Text;

                if (PropriedadesApp.list_usuarios.Any(i => (i.Email == email && i.senha == senha)))
                {
                    App.Current.Properties.Add("usuario_logado", email);
                    App.Current.MainPage = new protegida();
                }
                else
                {
                    throw new Exception("Dados incorretos, tente novamente.");
                    
                }
            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}