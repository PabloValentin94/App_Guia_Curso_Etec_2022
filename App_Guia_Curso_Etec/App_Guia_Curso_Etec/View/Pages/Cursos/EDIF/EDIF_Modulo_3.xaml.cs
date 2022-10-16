using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Guia_Curso_Etec.View.Pages.Cursos.EDIF
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class EDIF_Modulo_3 : ContentPage
    {

        public EDIF_Modulo_3()
        {

            InitializeComponent();

            lbl_titulo_modulo.Text = "Terceiro\nMódulo:";

        }

    }

}