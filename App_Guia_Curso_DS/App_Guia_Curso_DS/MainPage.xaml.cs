using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using App_Guia_Curso_DS.View.Pages;

namespace App_Guia_Curso_DS
{

    public partial class MainPage : MasterDetailPage
    {

        public MainPage()
        {

            InitializeComponent();

            // Definindo a imagem que aparecerá no menu.

            img_logo.Source = ImageSource.FromResource("App_Guia_Curso_DS.View.Images.logo.png");

            /* Detail: propriedade de uma MasterDetailPage. No contexto, do método construtor, a estamos usando para específicar qual será
             * a página que deverá ser acionada como página inicial (é tipo um Navigation.PushAsync(), só que da MasterDetailPage.). */

            /* No comando abaixo ocorrem vários processos. Vamos às explicações:
             *
             *    - Definindo que a página instanciada será uma NavigationPage, ou seja, poderá navegar para outras
             *      páginas (precisamos fazer isso para habilitarmos a função de troca de páginas.).
             *
             *    - Pegando o tipo do arquivo InicialPage.xaml e descobrindo se esse arquivo é equivalente a uma Page (página.).
             *
             *    - Caso o arquivo InicialPage.xaml seja equivalente a uma Page, então ele será instanciado/acionado/chamado. */

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(InicialPage)));

        }

        private void btn_ds_1_Clicked(object sender, EventArgs e)
        {

            /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
             * no método construtor. */

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Modulo_1)));

            IsPresented = false;

        }

        private void btn_ds_2_Clicked(object sender, EventArgs e)
        {

            /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
             * no método construtor. */

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Modulo_2)));

            IsPresented = false;

        }

        private void btn_ds_3_Clicked(object sender, EventArgs e)
        {

            /* Especificando a página que deverá ser acionada após o pressionamento do botão. Se necessário, revise as anotações presentes
             * no método construtor. */

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Modulo_3)));

            IsPresented = false;

        }

        /*
        private void btn_adm_1_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_adm_2_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_adm_3_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_meca_1_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_meca_2_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_meca_3_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_edif_1_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_edif_2_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_edif_3_Clicked(object sender, EventArgs e)
        {



        }
        */

    }

}
