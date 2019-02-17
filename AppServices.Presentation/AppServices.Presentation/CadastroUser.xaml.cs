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
	public partial class CadastroUser : ContentPage
	{
        private ObservableCollection<Conta> _contas;

        public CadastroUser ()
		{
            InitializeComponent();
            _contas = ContaService.GetContas();
            lvContas.ItemsSource = _contas;
            pRegiao.Items.Add("Região 1");
            pRegiao.Items.Add("Região 2");
            pRegiao.Items.Add("Região 3");
            pRegiao.Items.Add("Região 4");
           //await Navigation.PopAsync();

        }
        private void lvContas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var conta = e.SelectedItem as Conta;
            ////await Navigation.PushAsync(new ContaDetalhesPage(conta));
            //Detail = new ContaDetalhesPage(conta);
            ////para exibir a pagina de detalhes
            //IsPresented = false;
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