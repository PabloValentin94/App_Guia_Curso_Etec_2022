using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Guia_Curso_DS
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class InicialPage : ContentPage
    {

        public InicialPage()
        {

            InitializeComponent();

        }

        private void btn_vestibulinho_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new View.Pages.Vestibulinho());

        }

        private void btn_meios_contato_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new View.Pages.Meios_Contato());

        }

    }

}