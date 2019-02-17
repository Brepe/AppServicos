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
    public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

    void LoginPrestador(object sender, EventArgs args)
    {
        string login1 = "meu login";
        string senha1 = "123456";
        string response = "";

        if (lg.Text == login1)
        {
            if (pass.Text != senha1)
            {
                response = "senha incorreta para conta " + lg.Text + ".";
            }
            else
            {
                response = "login efetuado.";
            }
        }
        else
        {
            response = "login " + lg.Text + " não cadastrado.";
        }
        Resp.Text = response;
    }

    void LoginUser(object sender, EventArgs args)
    {
        string login1 = "meu login";
        string senha1 = "123456";
        string response = "";

        if (lg.Text == login1)
        {
            if (pass.Text != senha1)
            {
                response = "senha incorreta para conta " + lg.Text + ".";
            }
            else
            {
                response = "login efetuado.";
            }
        }
        else
        {
            response = "login " + lg.Text + " não cadastrado.";
        }
        Resp.Text = response;
    }

    async void CadastroPrestador(object sender, EventArgs args)
    {

        await Navigation.PushAsync(new Cadastro());
    }
    async void CadastroUser(object sender, EventArgs args)
    {

        await Navigation.PushAsync(new CadastroUser());
    }
}
}