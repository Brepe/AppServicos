using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppServices.Presentation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace AppServices.Presentation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroPrestador : ContentPage
	{
		public CadastroPrestador()

		{

            InitializeComponent();
            pRegiao.Items.Add("Zona sul");
            pRegiao.Items.Add("Zona norte");
            pRegiao.Items.Add("Zona oeste");
            pRegiao.Items.Add("Zona oeste 2");

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
            passRe.BackgroundColor = Color.FromHex("#FFF");
            pass.BackgroundColor = Color.FromHex("#FFF");
            mail.BackgroundColor = Color.FromHex("#FFF");
            cpf.BackgroundColor = Color.FromHex("#FFF");
            cnpj.BackgroundColor = Color.FromHex("#FFF");
            telefone.BackgroundColor = Color.FromHex("#FFF");
            nome.BackgroundColor = Color.FromHex("#FFF");
            if (FormValid(sender, args) == false){
                await DisplayAlert("Salvo!", "Agora aguarde nossa avaliação do seu cadastro", "Ok");

                await Navigation.PushAsync(new HomePageInside());
            }
            else
            {
               await DisplayAlert("Ei!", "Preencha todos os campos obrigatórios.", "Voltar e preencher");
            }
        }

        Boolean FormValid(object sender, EventArgs args)
        {
            Boolean formisvalid = true;

            if (((string.IsNullOrEmpty(pass.Text)) == true) || ((string.IsNullOrEmpty(passRe.Text) == true) || (passRe.Text != pass.Text)||(passRe.Text.Trim() == "" || pass.Text.Trim() == "")))
            {
                passRe.BackgroundColor = Color.FromHex("#e09a9a");
                pass.BackgroundColor = Color.FromHex("#e09a9a");
                formisvalid = false;
            }

            if (((string.IsNullOrEmpty(mail.Text)) == true) || ((mail.Text.Trim()).Length < 5 && !((mail.Text.Trim()).Contains("@")) && !((mail.Text.Trim()).Contains("."))))
            {
                mail.BackgroundColor = Color.FromHex("#e09a9a");
                formisvalid = false;
            }
            if (((string.IsNullOrEmpty(cpf.Text)) == true) || !(IsCpf(cpf.Text)))
            {
                
                cpf.BackgroundColor = Color.FromHex("#e09a9a");
                formisvalid = false;
            }
            if ((string.IsNullOrEmpty(cnpj.Text)) == false)
            {
                if (IsCnpj(cnpj.Text))
                {
                    cnpj.BackgroundColor = Color.FromHex("#e09a9a");
                    formisvalid = false;
                }
            }
            if (((string.IsNullOrEmpty(nome.Text)) == true) || ((nome.Text.Trim()).Length < 10))
            {
                nome.BackgroundColor = Color.FromHex("#e09a9a");
                formisvalid = false;
            }
            if (((string.IsNullOrEmpty(telefone.Text)) == true) || ((telefone.Text.Trim()).Length < 10))
            {
                telefone.BackgroundColor = Color.FromHex("#e09a9a");
                formisvalid = false;
            }


            return formisvalid;

        }
        // ---------------Para exibir os valores escolhidos no slider-------------------- //

        void DisplayGarcom(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            vGarcom.Text = String.Format("Preço por hora (garçom): {0}", value);
        }
        void DisplayFrita(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            vFrita.Text = String.Format("Preço por hora (fritadeira): {0}", value);
        }
        void DisplayCopeiro(object sender, ValueChangedEventArgs args)
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
        void ConfirmPass(object sender, TextChangedEventArgs e)
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

        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            Console.WriteLine(cpf.EndsWith(digito));


            return cpf.EndsWith(digito);
        }


        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}