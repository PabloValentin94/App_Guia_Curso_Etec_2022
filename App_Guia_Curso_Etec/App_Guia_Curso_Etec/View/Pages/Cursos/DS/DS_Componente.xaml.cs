using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Guia_Curso_Etec.View.Pages.Cursos.DS
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class DS_Componente : ContentPage
    {

        public DS_Componente()
        {

            InitializeComponent();

        }

        private async void btn_bases_tecnologicas_Clicked(object sender, EventArgs e)
        {

            try
            {

                var pagina = new DS_Bases_Tecnologicas();

                pagina.BindingContext = this.BindingContext;

                await Navigation.PushAsync(pagina);

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_competencias_Clicked(object sender, EventArgs e)
        {

            try
            {

                var pagina = new DS_Competencias();

                pagina.BindingContext = this.BindingContext;

                await Navigation.PushAsync(pagina);

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}