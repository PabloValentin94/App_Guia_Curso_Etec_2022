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

    public partial class Meios_Contato : ContentPage
    {

        public Meios_Contato()
        {

            InitializeComponent();

            // Definindo a imagem e o texto do Facebook:

            imgbtn_facebook.Source = ImageSource.FromResource("App_Guia_Curso_Etec.View.Images.Icons.facebook_icon.jpg");

            lbl_facebook.Text = "Perfil: Etec Joaquim Ferreira Do Amaral.\n\n" +
                                "Página: Etec Jau.";

            // Definindo a imagem e o texto do Instagram:

            imgbtn_instagram.Source = ImageSource.FromResource("App_Guia_Curso_Etec.View.Images.Icons.instagram_icon.png");

            lbl_instagram.Text = "Perfil: etecjau.";

            // Definindo a imagem e o texto do Site:

            imgbtn_site.Source = ImageSource.FromResource("App_Guia_Curso_Etec.View.Images.Icons.site_icon.png");

            lbl_site.Text = "Site: etecjau.com.br";

        }

        private async void imgbtn_facebook_Clicked(object sender, EventArgs e)
        {

            try
            {

                // 1 alternativa:

                /*
                 
                string escolha = await DisplayPromptAsync("Atenção!", // Título.
                                                          "Qual você deseja acessar?\n\n" +
                                                          "1: Perfil.\n2: Página.\n", // Mensagem.
                                                          "Confirmar", // Opção de confirmação.
                                                          cancel: null, // Opção de cancelamento.
                                                          placeholder: "Escolha entre o 1 ou o 2", // "Dica" que irá aparecer no campo de digitação
                                                          maxLength: 1, // Tamanho máximo que o campo pode ter.,
                                                          keyboard: Keyboard.Numeric);

                if (escolha == "1")
                {

                    Device.OpenUri(new Uri("https://www.facebook.com/etec.joaquimferreiradoamaral.1"));

                }

                else if (escolha == "2")
                {

                    Device.OpenUri(new Uri("https://www.facebook.com/etecjauoficial"));

                }

                else if (String.IsNullOrEmpty(escolha))
                {

                    await DisplayAlert("Atenção!", "Nenhuma escolha foi feita, portanto nada acontecerá.", "OK");

                }

                else
                {

                    throw new Exception("Valor inválido! Tente novamente.");

                }

                */

                // 2 alternativa:

                if(await DisplayAlert("Atenção!", "Escolha uma opção:", "Página", "Perfil"))
                {

                    Device.OpenUri(new Uri("https://www.facebook.com/etecjauoficial"));

                }

                else
                {

                    Device.OpenUri(new Uri("https://www.facebook.com/etec.joaquimferreiradoamaral.1"));

                }

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void imgbtn_instagram_Clicked(object sender, EventArgs e)
        {

            try
            {

                Device.OpenUri(new Uri("http://www.etecjau.com.br/etecjau/"));

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void imgbtn_site_Clicked(object sender, EventArgs e)
        {

            try
            {

                Device.OpenUri(new Uri("http://www.etecjau.com.br/etecjau/"));

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}