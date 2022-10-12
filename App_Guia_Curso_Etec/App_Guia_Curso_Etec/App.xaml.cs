using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Globalization; // Biblioteca que possui a propriedade CultureInfo.
using System.Threading; // Biblioteca que possui a propriedade Thread.

namespace App_Guia_Curso_Etec
{

    public partial class App : Application
    {

        public App()
        {

            InitializeComponent();

            // Deixando os elementos da aplicação (datas, horas, números, etc.) no padrão brasileiro.

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-br");

            MainPage = new MainPage();

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
