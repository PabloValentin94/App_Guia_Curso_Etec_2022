using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using App_Guia_Curso_Etec.View.Pages.Cursos.DS;

using App_Guia_Curso_Etec.View.Pages.Cursos.ADM;

using App_Guia_Curso_Etec.View.Pages.Cursos.MECA;

using App_Guia_Curso_Etec.View.Pages.Cursos.EDIF;

//using App_Guia_Curso_Etec.View.Pages.Cursos.MECA;

//using App_Guia_Curso_Etec.View.Pages.Cursos.EDIF;

namespace App_Guia_Curso_Etec
{

    public partial class MainPage : MasterDetailPage
    {

        public MainPage()
        {

            InitializeComponent();

            // Definindo a imagem que aparecerá no menu.

            img_logo.Source = ImageSource.FromResource("App_Guia_Curso_Etec.View.Images.logo.png");

            /* Detail: propriedade de uma MasterDetailPage. No contexto, do método construtor, a estamos usando para específicar qual será
             * a página que deverá ser acionada como página inicial (é tipo um Navigation.PushAsync(), só que da MasterDetailPage.). */

            /* No comando abaixo ocorrem vários processos. Vamos às explicações:
             *
             *    - Definindo que a página instanciada será uma NavigationPage, ou seja, poderá navegar para outras
             *      páginas (precisamos fazer isso para habilitarmos a função de troca de páginas.).
             *
             *    - Pegando o tipo do arquivo InitialPage.xaml e descobrindo se esse arquivo é equivalente a uma Page (página.).
             *
             *    - Caso o arquivo InitialPage.xaml seja equivalente a uma Page, então ele será instanciado/acionado/chamado. */

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(InitialPage)));

        }

        private async void btn_home_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(InitialPage)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_ds_1_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(DS_Modulo_1)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_ds_2_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(DS_Modulo_2)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_ds_3_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(DS_Modulo_3)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_adm_1_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ADM_Modulo_1)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_adm_2_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ADM_Modulo_2)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_adm_3_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ADM_Modulo_3)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_meca_1_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MECA_Modulo_1)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_meca_2_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MECA_Modulo_2)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_meca_3_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MECA_Modulo_3)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_edif_1_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(EDIF_Modulo_1)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_edif_2_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(EDIF_Modulo_2)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_edif_3_Clicked(object sender, EventArgs e)
        {

            try
            {

                /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
                 * no método construtor. */

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(EDIF_Modulo_3)));

                /* Garante que, após o pressionamento do botão, o menu será ocultado (irá sumir da frente do conteúdo.).
                 * Se a propriedade for definida como "true", então o menu permanecerá sobre o conteúdo. */

                IsPresented = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}
