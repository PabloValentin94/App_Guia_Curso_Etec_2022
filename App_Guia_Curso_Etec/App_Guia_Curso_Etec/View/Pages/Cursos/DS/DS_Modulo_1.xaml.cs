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

    public partial class DS_Modulo_1 : ContentPage
    {

        public DS_Modulo_1()
        {

            InitializeComponent();

            lbl_titulo_modulo.Text = "Primeiro\nMódulo:";

        }

        private async void btn_ana_pro_sis_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Análise e Projeto de Sistemas",

                    Carga_Horaria = 80,

                    Atribuicoes_Empreendedoras = "",

                    Atribuicoes_Responsabilidades = "- Elaborar projetos de sistema de informação.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Estimular a organização;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de situações - problema.",

                    Competencias = "1 - Modelar projetos de sistemas;\n\n" +
                                   "2 - Selecionar modelos para o desenvolvimento de sistemas.",

                    Habilidades = "1.1 - Coletar requisitos de usuários e sistemas;\n\n" +
                                  "1.2 - Utlizar métodos de abordagem e coleta de dados e " +
                                  "procedimentos de pesquisa.\n\n" +
                                  "2.1 - Aplicar modelo Cascata no desenvolvimento de sistemas;\n\n" +
                                  "2.2 - Aplicar modelos ágeis e projetos de software.",

                    Bases_Tecnologicas = "O conteúdo será colocado aqui."

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

        private async void btn_ban_dad_01_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Banco de Dados I",

                    Atribuicoes_Responsabilidades = "- Modelar banco de dados.",

                    Valores_Atitudes = "- Estimular a organização;\n\n" +
                                       "- Promover ações que considerem o respeito às normas estabelecidas;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de situações - problema."

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

        private async void btn_des_dig_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Design Digital",

                    Atribuicoes_Responsabilidades = "- Desenvolver interfaces visuais para aplicativos e sites;\n\n" +
                                                    "- Desenvolver elementos gráficos para aplicativos e sites.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Incentivar ações que promovam a cooperação;\n\n" +
                                       "- Respeitar as manifestações culturais de outros povos."

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

        private async void btn_fun_inf_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Fundamentos da Informática",

                    Atribuicoes_Responsabilidades = "- Operar sistemas computacionais.",

                    Valores_Atitudes = "- Desenvolver a criticidade;\n\n" +
                                       "- Incentivar comportamentos éticos;\n\n" +
                                       "- Promover ações que considerem o respeito às normas estabelecidas."

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

        private async void btn_pro_web_01_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Programação Web I",

                    Atribuicoes_Responsabilidades = "- Desenvolver sites para a Web.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Estimular a organização;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de situações - problema."

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

        private async void btn_pro_alg_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Técnicas de Programação e Algoritmos",

                    Atribuicoes_Responsabilidades = "- Verificar usabilidade no desenvolvimento de programas;\n\n" +
                                                    "- Realizar versionamento no desenvolvimento de programas;\n\n" +
                                                    "- Desenvolver programas de computador, utilizando princípios de boas práticas;\n\n" +
                                                    "- Implementar algoritmos em linguagem de programação, utilizando ambientes de " +
                                                    "desenvolvimento de acordo com as necessidades.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Incentivar atitudes de autonomia;\n\n" +
                                       "- Incentivar comportamentos éticos;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de situações-problema."

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