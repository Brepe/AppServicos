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
	public partial class Cadastro : ContentPage
	{
		public Cadastro ()

		{

            InitializeComponent();
            pRegiao.Items.Add("Região 1");
            pRegiao.Items.Add("Região 2");
            pRegiao.Items.Add("Região 3");
            pRegiao.Items.Add("Região 4");

            pMaterial.Items.Add("Região 1");
            pMaterial.Items.Add("Região 2");
            pMaterial.Items.Add("Região 3");
            pMaterial.Items.Add("Região 4");
            //await Navigation.PopAsync();
            svGarcom.SetValue(IsVisibleProperty, false);
            svFrita.SetValue(IsVisibleProperty, false);
            svCopeira.SetValue(IsVisibleProperty, false);
            vGarcom.SetValue(IsVisibleProperty, false);
            vFrita.SetValue(IsVisibleProperty, false);
            vCopeira.SetValue(IsVisibleProperty, false);
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new MainPage());
        }

        // ---------------Para exibir os valores escolhidos no slider-------------------- //

        void ExibeGarcom(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            vGarcom.Text = String.Format("Preço por hora (garçom): {0}", value);
        }
        void ExibeFrita(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            vFrita.Text = String.Format("Preço por hora (fritadeira): {0}", value);
        }
        void ExibeCopeiro(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            vCopeira.Text = String.Format("Preço por hora (copeira): {0}", value);
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            if (value == 0){
                uni.Text = String.Format("Não");
            }
            else
            {
                uniSlider.Value = 1;
                uni.Text = String.Format("Sim");
            }

        }

        // --------------Para exibir os slider somente se for preenchida qtd------------ //

        void HideandShowSlider(object sender, TextChangedEventArgs e)
        {
            String value = e.NewTextValue;
            if (value.Trim() != "" && value.Trim() != "0")
            {
                svGarcom.SetValue(IsVisibleProperty, true);
                vGarcom.SetValue(IsVisibleProperty, true);

            }
            else
            {
                svGarcom.SetValue(IsVisibleProperty, false);
                vGarcom.SetValue(IsVisibleProperty, false);

            }
        }
        void HideandShowSlider2(object sender, TextChangedEventArgs e)
        {
            String value = e.NewTextValue;
            if (value.Trim() != "" && value.Trim() != "0")
            {
                svFrita.SetValue(IsVisibleProperty, true);
                vFrita.SetValue(IsVisibleProperty, true);

            }
            else
            {
                svFrita.SetValue(IsVisibleProperty, false);
                vFrita.SetValue(IsVisibleProperty, false);

            }

        }
        void HideandShowSlider3(object sender, TextChangedEventArgs e)
        {
            String value = e.NewTextValue;
            if (value.Trim() != "" && value.Trim() != "0")
            {
                svCopeira.SetValue(IsVisibleProperty, true);
                vCopeira.SetValue(IsVisibleProperty, true);

            }
            else
            {
                svCopeira.SetValue(IsVisibleProperty, false);
                vCopeira.SetValue(IsVisibleProperty, false);

            }

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