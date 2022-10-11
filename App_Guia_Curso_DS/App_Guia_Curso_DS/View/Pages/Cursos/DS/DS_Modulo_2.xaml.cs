using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Guia_Curso_Etec.View.Pages.Cursos.DS;

namespace App_Guia_Curso_Etec.View.Pages.Cursos.DS
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class DS_Modulo_2 : ContentPage
    {

        public DS_Modulo_2()
        {

            InitializeComponent();

        }

        private void btn_ban_dad_02_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Banco de Dados II"

                };

                var pagina = new DS_Componente();

                pagina.BindingContext = dados;

                Navigation.PushAsync(pagina);

            }

            catch(Exception ex)
            {

                DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private void btn_des_sis_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Desenvolvimento de Sistemas"

                };

                var pagina = new DS_Componente();

                pagina.BindingContext = dados;

                Navigation.PushAsync(pagina);

            }

            catch (Exception ex)
            {

                DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private void btn_pro_mob_01_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Programação Mobile I"

                };

                var pagina = new DS_Componente();

                pagina.BindingContext = dados;

                Navigation.PushAsync(pagina);

            }

            catch (Exception ex)
            {

                DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private void btn_pro_web_02_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Programação Web II"

                };

                var pagina = new DS_Componente();

                pagina.BindingContext = dados;

                Navigation.PushAsync(pagina);

            }

            catch (Exception ex)
            {

                DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private void btn_sis_emb_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Sistemas Embarcados"

                };

                var pagina = new DS_Componente();

                pagina.BindingContext = dados;

                Navigation.PushAsync(pagina);

            }

            catch (Exception ex)
            {

                DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}