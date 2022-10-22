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

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Implementar bancos de dados.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Desenvolver a criticidade;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de situações - problema.",

                    Competencias = "1 - Implementar banco de dados relacional utilizando o Sistema Gerenciador de banco de dados;\n\n" +
                                   "2 - Otimizar a linguagem de consulta estruturada como forma de informação relevante para a " +
                                   "tomada de decisão.",

                    Habilidades = "1.1 - Utilizar sistema de gerenciamento para banco de dados.\n\n" +
                                  "2.1 - Executar linguagem de consulta estruturada objetivando melhor desempenho;\n\n" +
                                  "2.2 - Compilar relatórios analíticos a partir dos dados coletados.",

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

        private async void btn_des_sis_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Desenvolvimento de Sistemas",

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Analisar e projetar sistemas de informação, selecionando linguagens de programação e ambientes " +
                                                    "de desenvolvimento de acordo com as especificidades do projeto;\n\n" +
                                                    "- Codificar e depurar programas.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes =  "- Fortalecer a persistência e o interesse na resolução de situações - problema;\n\n" +
                                        "- Incentivar ações que promovam a cooperação;\n\n" +
                                        "- Desenvolver a criatividade.",

                    Competencias = "1 - Projetar sistemas de informação, selecionando linguagens de programação e ambientes " +
                                   "de desenvolvimento de acordo com as especificidades do projeto.",

                    Habilidades = "1.1 - Codificar programas orientados a objetos;\n\n" +
                                  "1.2 - Utilizar ambientes de desenvolvimento para desenvolvimento desktop;\n\n" +
                                  "1.3 - Conectar aplicações com banco de dados;\n\n" +
                                  "1.4 - Aplicar técnicas de orientação a objetos;\n\n" +
                                  "1.5 - Construir interface gráfica.",

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

        private async void btn_pro_mob_01_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Programação de Aplicativos Mobile I",

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Elaborar projetos de aplicativos para platarformas móveis.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Responsabilizar-se pela produção, utilização e divulgação de informações;\n\n" +
                                       "- Estimular a organização.",

                    Competencias = "1 - Projetar aplicativos, selecionando linguagens de programação e ambientes de desenvolvimento.",

                    Habilidades = "1.1 - Utilizar ambientes de desenvolvimento de software mobile;\n\n" +
                                  "1.2 - Construir interface gráfica para aplicativos mobile;\n\n" +
                                  "1.3 - Utilizar recursos de aparelhos celulares e tablets.",

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

        private async void btn_pro_web_02_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Programação Web II",

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Planejar projetos de sistemas de informação para a Web.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Responsabilizar-se pela produção, utilização e divulgação de informações;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de situações - problema;\n\n" +
                                       "- Incentivar a criatividade.",

                    Competencias = "1 - Desenvolver sistemas para internet utilizando persistência em banco de dados, " +
                                   "interface com ousuário e programação em lado servidor.",

                    Habilidades = "1.1 - Codificar software em linguagem para Web;\n\n" +
                                  "1.2 - Utilizar banco de dados relacionais para persistência dos dados;\n\n" +
                                  "1.3 - Utilizar interface baseada em navegador para interação com usuário.",

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

        private async void btn_sis_emb_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Sistemas Embarcados",

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Desenvolver sistemas embarcados.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Fortalecer a persistência e o interesse na resolução de situações - problema;\n\n" +
                                       "- Estimular a organização;\n\n" +
                                       "- Incentivar a criatividade.",

                    Competencias = "1 - Analisar modelos de sistemas embarcados;\n\n" +
                                   "2 - Desenvolver aplicações com microcontroladores.",

                    Habilidades = "1.1 - Identificar as características de sistemas embarcados.\n\n" +
                                  "2.1 - Programar sistemas para microcontroladores;\n\n" +
                                  "2.2 - Executar instruções para microcontroladores.",

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