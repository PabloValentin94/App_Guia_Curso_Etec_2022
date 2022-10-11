using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Guia_Curso_Etec
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class InitialPage : ContentPage
    {

        public InitialPage()
        {

            InitializeComponent();

            lbl_sobre_unidade.Text = "A unidade iniciou as atividades em 1928, com cursos de Fundição, " +
                                     "de Mecânica de Máquinas, de Marcenaria e de Corte e Costura. Em 1985, " +
                                     "a Etec passou a integrar as escolas da Divisão de Supervisão e Apoio as Escolas " +
                                     "Técnicas Estaduais e, em 1991, foi transferida para a Divisão Estadual de Ensino " +
                                     "Técnico (DEET) da Secretaria de Ciência, Tecnologia e Desenvolvimento Econômico. " +
                                     "Foi incorporada ao Centro Paula Souza em 1994.";

            img_hallowtec.Source = ImageSource.FromResource("App_Guia_Curso_Etec.View.Images.hallowtec.png");

            lbl_endereco.Text = "País: Brasil.\n\nEstado: São Paulo (S.P.).\n\nCidade: Jaú.\n\n" +
                                "Rua: Humaitá.\n\nNº: 1090 - Centro.\n\nCEP: 17.201-320";

        }

        private void btn_vestibulinho_Clicked(object sender, EventArgs e)
        {

            try
            {

                Navigation.PushAsync(new View.Pages.Vestibulinho());

            }

            catch(Exception ex)
            {

                DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private void btn_meios_contato_Clicked(object sender, EventArgs e)
        {

            try
            {

                Navigation.PushAsync(new View.Pages.Meios_Contato());

            }

            catch(Exception ex)
            {

                DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}