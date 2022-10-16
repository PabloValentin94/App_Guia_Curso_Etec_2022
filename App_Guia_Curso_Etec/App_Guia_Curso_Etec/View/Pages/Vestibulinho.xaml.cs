using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Guia_Curso_Etec.View.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Vestibulinho : ContentPage
    {

        public Vestibulinho()
        {

            InitializeComponent();

            /*lbl_definicao_vestibulinho.Text = "O vestibulinho é um processo seletivo que seleciona candidatos para as Escolas Técnicas " +
                                              "Estaduais (Etecs).";

            lbl_metodologia_vestibulinho.Text = "O vestibulinho é realizado através de uma avaliação presencial, tendo sido, as únicas excessões, " +
                                                "os vestibulinhos de 2.020 e 2.021, devido a pandemia do Covid-19, que tornou impossível o método " +
                                                "de avaliação presencial. Nesse período, o critério de avaliação foi referente ao histórico escolar do " +
                                                "participante/inscrito.";*/

        }

        private async void btn_site_vestibulinho_Clicked(object sender, EventArgs e)
        {

            try
            {

                Device.OpenUri(new Uri("https://www.vestibulinhoetec.com.br/"));

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}