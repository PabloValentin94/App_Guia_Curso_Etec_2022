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

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Implementar rotinas de segurança da informação;\n\n" +
                                                    "- Utilizar protocolos de redes e internet para comunicação de dados.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Incentivar comportamentos éticos;\n\n" +
                                       "- Promover ações que considerem o respeito às normas estabelecidas;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de situações - problema.",

                    Competencias = "1 - Configurar os principais serviços de redes de comunicação de dados e internet " +
                                   "para o desenvolvimento de sistemas;\n\n" +
                                   "2 - Desenvolver sistemas implementando rotinas de segurança de dados.",

                    Habilidades = "1.1 - Identificar modelo de referência de arquitetura de redes de comunicação de " +
                                  "dados e internet paraa escolha de protocolos adequados aos sistemas em desenvolvimento;\n\n" +
                                  "1.2 - Utilizar protocolos de rede e de comunicação de dados que auxiliem no " +
                                  "desenvolvimento de sistemas.\n\n" +
                                  "2.1 - Identificar ameaças à segurança da informação;\n\n" +
                                  "2.2 - Utilizar técnicas de segurança da informação;\n\n" +
                                  "2.3 - Operar mecanismos de segurança da informação no desenvolvimento de sistemas.",

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

        private async void btn_pla_des_tcc_ds_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Planejamento e Desenvolvimento do Trabalho de Conclusão de Curso (T.C.C.) " +
                           "em Desenvolvimento de Sistemas",

                    Carga_Horaria = 120,

                    Atribuicoes_Responsabilidades = "- Planejar e desenvolver projetos de sistemas computacionais.",

                    Atribuicoes_Empreendedoras = "- Comunicar-se com a equipe com clareza e objetividade;\n\n" +
                                                 "- Demonstrar comprometimento com a equipe e o trabalho;\n\n" +
                                                 "- Planejar ações mais eficazes no desenvolvimento de sistemas;\n\n" +
                                                 "- Organizar procedimentos de maneira diversa, visando melhor eficiência.",

                    Valores_Atitudes = "- Estimular a organização;\n\n" +
                                       "- Incentivar comportamentos éticos;\n\n" +
                                       "- Responsabilizar-se pela produção, utilização e divulgação de informações.",

                    Competencias = "➡ 1º Semestre:\n\n" +

                                   "1 - Analisar dados e informações obtidas de pesquisas empíricas e bibliográficas;\n\n" +
                                   "2 - Propor soluções parametrizadas por viabilidade técnica e econômica aos " +
                                   "problemas identificados no âmbito da área profissional;\n\n" +
                                   "3 - Correlacionar a formação técnica às demandas do setor produtivo voltadas " +
                                   "para gestão ambiental e Segurança do Trabalho;\n\n" +
                                   "4 - Construir projeto de software.\n\n" +
                                   
                                   "➡ 2º Semestre:\n\n" +

                                   "1 - Planejar as fases de execução de projetos com base na natureza e na complexidade " +
                                   "das atividades;\n\n" +
                                   "2 - Avaliar as fontes e recursos necessários para o desenvolvimento de projetos;\n\n" +
                                   "3 - Avaliar a execução e os resultados obtidos de forma quantitativa e qualitativa;\n\n" +
                                   "4 - Utilizar princípios inovadores de Empreendedorismo na criação de projetos / " +
                                   "startups de tecnologia;\n\n" +
                                   "5 - Documentar sistemas de informação.",

                    Habilidades = "➡ 1º Semestre:\n\n" +

                                  "1.1 - Identificar demandas e situações-problema no âmbito da área profissional;\n\n" +
                                  "1.2 - Identificar fontes de pesquisa sobre o objeto em estudo;\n\n" +
                                  "1.3 - Elaborar instrumentos de pesquisa para desenvolvimento de projetos;\n\n" +
                                  "1.4 - Constituir amostras para pesquisas técnicas e científicas, de forma criteriosa e explicitada;\n\n" +
                                  "1.5 - Aplicar instrumentos de pesquisa de campo.\n\n" +
                                  "2.1 - Consultar legislação, normas e regulamentos relativos ao projeto;\n\n" +
                                  "2.2 - Registrar as etapas do trabalho;\n\n" +
                                  "2.3 - Organizar os dados obtidos na forma de textos, planilhas, gráficos e esquemas.\n\n" +
                                  "3.1 - Consultar legislação, normas e regulamentos relativos ao projeto.\n\n" +
                                  "4.1 - Elaborar modelo de negócio para uma empresa de software;\n\n" +
                                  "4.2 - Articular conhecimentos de empreendedorismo na construção de projetos de software.\n\n" +

                                  "➡ 2º Semestre:\n\n" +

                                  "1.1 - Consultar diversas fontes de pesquisa: catálogos, manuais de fabricantes, " +
                                  "glossários técnicos, entre outros;\n\n" +
                                  "1.2 - Comunicar ideias de forma clara e objetiva por meio de textos escritos " +
                                  "e de explanações orais.\n\n" +
                                  "2.1 - Definir recursos necessários e plano de produção;\n\n" +
                                  "2.2 - Classificar os recursos necessários para o desenvolvimento do projeto;\n\n" +
                                  "2.3 - Utilizar, de modo racional, os recursos destinados ao projeto.\n\n" +
                                  "3.1 - Verificar e acompanhar o desenvolvimento do cronograma físico - financeiro;\n\n" +
                                  "3.2 - Redigir relatórios sobre o desenvolvimento do projeto;\n\n" +
                                  "3.3 - Construir gráficos, planilhas, cronogramas e fluxogramas;\n\n" +
                                  "3.4 - Organizar informações, textos e dados conforme formatação definida.\n\n" +
                                  "4.1 - Elaborar proposta de projeto de conclusão de curso / startup;\n\n" +
                                  "4.2 - Articular conhecimentos de Empreendedorismo.\n\n" +
                                  "5.1 - Elaborar diagramas na linguagem de modelagem unificada;\n\n" +
                                  "5.2 - Indicar utilização adequada do sistema projetado.",

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

        private async void btn_pro_mob_02_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Programação de Aplicativos Mobile II",

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Documentar, construir e manter sistemas de informação para plataformas móveis.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Estimular a organização;\n\n" +
                                       "- Responsabilizar-se pela produção, utilização e divulgação de informações.",

                    Competencias = "1 - Projetar aplicativos selecionando linguagens de programação e " +
                                   "ambientes de desenvolvimento.",

                    Habilidades = "1.1 - Utilizar ambientes de desenvolvimento mobile;\n\n" +
                                  "1.2 - Elaborar aplicativos com acesso a banco de dados;\n\n" +
                                  "1.3 - Construir layout de aplicativos para dispositivos móveis;\n\n" +
                                  "1.4 - Utilizar recursos avançados do dispositivo (smartphones e tablets).",

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

        private async void btn_pro_web_03_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Programação Web III",

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Documentar, construir e manter sistemas de informação para Web.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Incentivar a criatividade;\n\n" +
                                       "- Responsabilizar-se pela produção, utilização e divulgação de informações;\n\n" +
                                       "- Fortalecer a persistência e o interesse na resolução de situações - problema.",

                    Competencias = "1 - Desenvolver sistemas multicamadas, utilizando framework de desenvolvimento Web;\n\n" +
                                   "2 - Desenvolver serviços para o usuário utilizando recursos dos dispositivos móveis.",

                    Habilidades = "1.1 - Utilizar conjunto de bibliotecas (framework) para o desenvolvimento Web.\n\n" +
                                  "2.1 - Utilizar recursos dos dispositivos móveis na integração de aplicativos " +
                                  "à Internet;\n\n" +
                                  "2.2 - Construir aplicativos para a Internet.",

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

        private async void btn_qua_tes_sof_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Componente dados = new Model.Componente()
                {

                    Nome = "Qualidade e Teste de Software",

                    Carga_Horaria = 80,

                    Atribuicoes_Responsabilidades = "- Testar softwares para melhoria da qualidade de sistemas;\n\n" +
                                                    "- Elaborar registros e planilhas de acompanhamento e controle das atividades.",

                    Atribuicoes_Empreendedoras = "- Nenhuma.",

                    Valores_Atitudes = "- Desenvolver a criticidade;\n\n" +
                                       "- Incentivar comportamentos éticos;\n\n" +
                                       "- Responsabilizar-se pela produção, utilização e divulgação de informações.",

                    Competencias = "1 - Avaliar e selecionar técnicas de teste de software.",

                    Habilidades = "1.1 - Utilizar softwares de apoio ao teste de sistemas;\n\n" +
                                  "1.2 - Verificar e validar correspondência entre a especificação e o produto testado.",

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