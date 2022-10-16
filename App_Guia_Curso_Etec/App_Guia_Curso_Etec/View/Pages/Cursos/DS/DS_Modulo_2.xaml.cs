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

            lbl_titulo_modulo.Text = "Segundo\nMódulo:";

        }

        private async void btn_ban_dad_02_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Banco de Dados II",

                    Atribuicoes_Responsabilidades = "- Implementar bancos de dados.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Desenvolver a criticidade;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de Situações - problema."

                };

                var pagina = new DS_Componente();

                pagina.BindingContext = dados;

                await Navigation.PushAsync(pagina);

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_des_sis_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Desenvolvimento de Sistemas",

                    Atribuicoes_Responsabilidades = "- Analisar e projetar sistemas de informação, selecionando linguagens de programação e ambientes " +
                                                    "de desenvolvimento de acordo com as especificações do projeto;\n\n" +
                                                    "- Codificar e depurar programas.",

                    Valores_Atitudes =  "- Fortalecer a persistência e o interesse na resolução de Situações - problema;\n\n" +
                                        "- Incentivar ações que promovam a cooperação;\n\n" +
                                        "- Desenvolver a criatividade."

                };

                var pagina = new DS_Componente();

                pagina.BindingContext = dados;

                await Navigation.PushAsync(pagina);

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_pro_mob_01_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Programação de Aplicativos Mobile I",

                    Atribuicoes_Responsabilidades = "- Elaborar projetos de aplicativos para platarformas móveis.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Responsabilizar-se pela produção, utilização e divulgação de informações;\n\n" +
                                       "- Estimular a organização."

                };

                var pagina = new DS_Componente();

                pagina.BindingContext = dados;

                await Navigation.PushAsync(pagina);

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_pro_web_02_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Programação Web II",

                    Atribuicoes_Responsabilidades = "- Planejar projetos de sistemas de informação para Web.",

                    Valores_Atitudes = "- Responsabilizar-se pela produção, utilização e divulgação de informações;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de Situações - problema;\n\n" +
                                       "- Incentivar a criatividade."

                };

                var pagina = new DS_Componente();

                pagina.BindingContext = dados;

                await Navigation.PushAsync(pagina);

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_sis_emb_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Sistemas Embarcados",

                    Atribuicoes_Responsabilidades = "- Desenvolver sistemas embarcados.",

                    Valores_Atitudes = "- Fortalecer a persistência e o interesse na resolução de Situações - problema;\n\n" +
                                       "- Estimular a organização;\n\n" +
                                       "- Incentivar a criatividade."

                };

                var pagina = new DS_Componente();

                pagina.BindingContext = dados;

                await Navigation.PushAsync(pagina);

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}