using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppServices.Presentation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            

        }



         void OnButtonClicked(object sender, EventArgs args)
        {
            String login1 = "Meu login";
            String senha1 = "123456";
            String response = "";

            if (lg.Text == login1)
            {
                if (pass.Text != senha1)
                {
                    response = "Senha incorreta para conta " + lg.Text + ".";
                }
                else
                {
                    response = "Login efetuado.";
                }
            }
            else
            {
                response = "Login " + lg.Text + " não cadastrado.";
            }
            Resp.Text = response;
        }
        async void OnButtonClicked2(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new Cadastro());
        }
    }
}
