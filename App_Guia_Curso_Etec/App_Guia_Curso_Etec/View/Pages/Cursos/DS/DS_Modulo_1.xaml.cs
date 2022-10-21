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

                    Atribuicoes_Responsabilidades = "- Elaborar projetos de sistema de informação.",

                    Atribuicoes_Empreendedoras = "- Analizar métodos de execução otimizados.",

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

                    Bases_Tecnologicas = "- O conteúdo será colocado aqui."

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

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Modelar banco de dados.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Estimular a organização;\n\n" +
                                       "- Promover ações que considerem o respeito às normas estabelecidas;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de situações - problema.",

                    Competencias = "1 - Desenvolver modelo de banco de dados.",

                    Habilidades = "1.1 - Levantar a necessidade de informações do sistema;\n\n" +
                                  "1.2 - Normalizar tabelas de banco de dados;\n\n" +
                                  "1.3 - Associar tabelas para construção de banco de dados;\n\n" +
                                  "1.4 - Aplicar a linguagem SQL na contrução de tabelas.",

                    Bases_Tecnologicas = "- O conteúdo será colocado aqui."

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

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Desenvolver interfaces visuais para aplicativos e sites;\n\n" +
                                                    "- Desenvolver elementos gráficos para aplicativos e sites.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Incentivar ações que promovam a cooperação;\n\n" +
                                       "- Respeitar as manifestações culturais de outros povos.",

                    Competencias = "1 - Desenvolver interfaces visuais para aplicativos e sites.",

                    Habilidades = "1.1 - Manipular e/ou construir elementos visuais para aplicativos e sites.",

                    Bases_Tecnologicas = "- O conteúdo será colocado aqui."

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

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Operar sistemas computacionais.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Desenvolver a criticidade;\n\n" +
                                       "- Incentivar comportamentos éticos;\n\n" +
                                       "- Promover ações que considerem o respeito às normas estabelecidas.",

                    Competencias = "1 - Articular conhecimentos de sistemas computacionais;\n\n" +
                                   "2 - Distinguir sistemas computacionais.",

                    Habilidades = "1.1 - Distinguir arquiteturas de sistemas de hardware e software;\n\n" +
                                  "1.2 - Executar comandos em interface de linha de comando.\n\n" +
                                  "2.1 - Utilizar sistemas computacionais.",

                    Bases_Tecnologicas = "- O conteúdo será colocado aqui."

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

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Desenvolver sites para a Web.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Estimular a organização;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de situações - problema.",

                    Competencias = "1 - Desenvolver páginas para a Internet.",

                    Habilidades = "1.1 - Contruir páginas para a Internet, utilizando linguagem de marcação de texto;\n\n" +
                                  "1.2 - Utlizar linguagem de script para a Web\n\n" +
                                  "1.3 - Aplicar formatação através de folhas de estilo.\n\n",

                    Bases_Tecnologicas = "- O conteúdo será colocado aqui."

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

                    Carga_Horaria = 120,

                    Atribuicoes_Responsabilidades = "- Verificar usabilidade no desenvolvimento de programas;\n\n" +
                                                    "- Realizar versionamento no desenvolvimento de programas;\n\n" +
                                                    "- Desenvolver programas de computador, utilizando princípios de boas práticas;\n\n" +
                                                    "- Implementar algoritmos em linguagem de programação, utilizando ambientes de " +
                                                    "desenvolvimento de acordo com as necessidades.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Incentivar atitudes de autonomia;\n\n" +
                                       "- Incentivar comportamentos éticos;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de situações-problema.",

                    Competencias = "1 - Implementar algoritmos de programação;\n\n" +
                                   "2 - Desenvolver sistemas, aplicando princípios e paradigmas de programação.",

                    Habilidades = "1.1 - Elaborar algoritmos.\n\n" +
                                  "2.1 - Codificar programas, utilizando técnicas de programação estruturada\n\n" +
                                  "2.2 - Depurar e versionar programas, utilizando ambiente de desenvolvimento integrado.",

                    Bases_Tecnologicas = "- O conteúdo será colocado aqui."

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