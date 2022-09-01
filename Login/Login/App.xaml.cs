using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

using Login.View;
using Login.Model;

namespace Login
{
    public partial class App : Application
    {
        public static List<Dados> list_usuarios = new List<Dados>
        {
            new Dados()
            {
                Email = "Teste@gmail",
                Nome = "Teste",
                senha = "123"
            },

            new Dados()
            {
                Email = "Teste2@gmail",
                Nome = "Teste2",
                senha = "1234"
            }
        };


        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
            {
                MainPage = new protegida();
            }
            else
            {
                MainPage = new login();
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
