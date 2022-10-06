using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Guia_Curso_DS
{

    public partial class MainPage : MasterDetailPage
    {

        public MainPage()
        {

            InitializeComponent();

            img_logo.Source = ImageSource.FromResource("App_Guia_Curso_DS.View.Images.logo.png");

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(InicialPage)));

        }

        private void btn_ds_1_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_ds_2_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_ds_3_Clicked(object sender, EventArgs e)
        {



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
