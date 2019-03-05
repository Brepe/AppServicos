using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppServices.Presentation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    //	public partial class HomePage : ContentView
    public partial class HomePageInside : ContentPage
	{
		public HomePageInside()
		{

            InitializeComponent ();
            label01.Text += "Fulano!";
            label_total.Text += "3.500,00";
            label_caixa.Text += "250,00";
            
            listView1.ItemsSource = new List<String>
            {
                "- R$350,00 em 10/04/2019 >",
                "- R$53,00 em 30/11/2019 >",
                "- R$1620,00 em 15/06/2019 >",
                "- R$130,00 em 10/05/2019 >"
            };
            listView2.ItemsSource = new List<String>
            {
                "- Nº 00012 em 10/04/2019 >",
                "- Nº 00010 em 30/04/2019 >",
                "- Nº 00008 em 15/06/2019 >",
                "- Nº 00003 em 04/07/2019 >"
            };

        }


    }
}