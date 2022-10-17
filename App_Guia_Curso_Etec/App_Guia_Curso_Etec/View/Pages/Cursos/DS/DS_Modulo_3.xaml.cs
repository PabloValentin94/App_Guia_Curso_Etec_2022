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

    public partial class DS_Modulo_3 : ContentPage
    {

        public DS_Modulo_3()
        {

            InitializeComponent();

            lbl_titulo_modulo.Text = "Terceiro\nMódulo:";

        }

        private async void btn_sis_inf_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Internet, Protocolos e Segurança de Sistemas da Informação",

                    Atribuicoes_Responsabilidades = "- Implementar rotinas de segurança da informação;\n\n" +
                                                    "- Utilizar protocolos de redes e internet para comunicação de dados.",

                    Valores_Atitudes = "- Incentivar comportamentos éticos;\n\n" +
                                       "- Promover ações que considerem o respeito às normas estabelecidas;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de situações - problema."

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

        private async void btn_pla_des_tcc_ds_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Planejamento e Desenvolvimento do Trabalho de Conclusão de Curso (T.C.C.) " +
                           "em Desenvolvimento de Sistemas",

                    Atribuicoes_Responsabilidades = "- Planejar e desenvolver projetos de sistemas computacionais.",

                    Valores_Atitudes = "- Comunicar-se com a equipe com clareza e objetividade;\n\n" +
                                       "- Demonstrar comprometimento com a equipe e o trabalho;\n\n" +
                                       "- Planejar ações mais eficazes no desenvolvimento de sistemas;\n\n" +
                                       "- Organizar procedimentos de maneira diversa, visando melhor eficiência."

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

        private async void btn_pro_mob_02_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Programação de Aplicativos Mobile II",

                    Atribuicoes_Responsabilidades = "- Documentar, construir e manter sistemas de informação para plataformas móveis.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Estimular a organização;\n\n" +
                                       "- Responsabilizar-se pela produção, utilização e divulgação de informações."

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

        private async void btn_pro_web_03_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Programação Web III",

                    Atribuicoes_Responsabilidades = "- Documentar, construir e manter sistemas de informação para Web.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Responsabilizar-se pela produção, utilização e divulgação de informações;\n\n" +
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

        private async void btn_qua_tes_sof_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Qualidade e Teste de Software",

                    Atribuicoes_Responsabilidades = "- Testar softwares para melhoria da qualidade de sistemas;\n\n" +
                                                    "- Elaborar registros e planilhas de acompanhamento e controle das atividades.",

                    Valores_Atitudes = "- Desenvolver a criticidade;\n\n" +
                                       "- Incentivar comportamentos éticos;\n\n" +
                                       "- Responsabilizar-se pela produção, utilização e divulgação de informações."

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