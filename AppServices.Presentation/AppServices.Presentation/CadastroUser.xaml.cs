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
	public partial class CadastroUser : ContentPage
	{
		public CadastroUser ()
		{
            InitializeComponent();
            pRegiao.Items.Add("Região 1");
            pRegiao.Items.Add("Região 2");
            pRegiao.Items.Add("Região 3");
            pRegiao.Items.Add("Região 4");
           //await Navigation.PopAsync();

        }

        async void OnButtonClicked(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new MainPage());
        }


        // --------------------------- Confirmar senha ----------------------------------//
        void ConfirmarSenha(object sender, TextChangedEventArgs e)
        {
            if (passRe.Text != pass.Text)
            {
                passRe.BackgroundColor = Color.FromHex("#e09a9a");

            }
            else
            {
                passRe.BackgroundColor = Color.FromHex("#ffffff");

            }
        }

    }
}