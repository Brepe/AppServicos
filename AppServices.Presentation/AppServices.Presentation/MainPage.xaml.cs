using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
//using Infrastructure.SQLServer;
//using AppService.Services;
using AppServices.Presentation;

namespace AppServices.Presentation
{
    public partial class MainPage : MasterDetailPage
    {
        //private ObservableCollection<Conta> _contas;
        private ObservableCollection<MasterPageItem> _menuLista;

        public MainPage()
        {
            InitializeComponent();
            //_contas = ContaService.GetContas();
            //lvContas.ItemsSource = _contas;
            _menuLista = ItemService.GetMenuItens();
            navigationDrawerList.ItemsSource = _menuLista;
            // Define a propriedade ItemSource da pagina MainPage.xaml
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }



        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            //obtem o tipo de objeto 
            Type pagina = item.TargetType;

            //abre a pagina correspondente ao item selecionado
            //Cria uma instância do tipo especificado usando o construtor
            //que melhor se adequa ao parametro informado
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
            IsPresented = false;
        }
    }
}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xamarin.Forms;

//namespace AppServices.Presentation
//{
//    public partial class MainPage : ContentPage
//    {
//        public MainPage()
//        {
//            InitializeComponent();


//        }

//         void LoginPrestador(object sender, EventArgs args)
//        {
//            String login1 = "Meu login";
//            String senha1 = "123456";
//            String response = "";

//            if (lg.Text == login1)
//            {
//                if (pass.Text != senha1)
//                {
//                    response = "Senha incorreta para conta " + lg.Text + ".";
//                }
//                else
//                {
//                    response = "Login efetuado.";
//                }
//            }
//            else
//            {
//                response = "Login " + lg.Text + " não cadastrado.";
//            }
//            Resp.Text = response;
//        }

//        void LoginUser(object sender, EventArgs args)
//        {
//            String login1 = "Meu login";
//            String senha1 = "123456";
//            String response = "";

//            if (lg.Text == login1)
//            {
//                if (pass.Text != senha1)
//                {
//                    response = "Senha incorreta para conta " + lg.Text + ".";
//                }
//                else
//                {
//                    response = "Login efetuado.";
//                }
//            }
//            else
//            {
//                response = "Login " + lg.Text + " não cadastrado.";
//            }
//            Resp.Text = response;
//        }

//        async void CadastroPrestador(object sender, EventArgs args)
//        {

//            await Navigation.PushAsync(new Cadastro());
//        }
//        async void CadastroUser(object sender, EventArgs args)
//        {

//            await Navigation.PushAsync(new CadastroUser());
//        }
//    }
//}
