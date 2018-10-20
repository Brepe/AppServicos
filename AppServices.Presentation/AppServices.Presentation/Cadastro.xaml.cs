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
            myPicker.Items.Add("Região 1");
            myPicker.Items.Add("Região 2");
            myPicker.Items.Add("Região 3");
            myPicker.Items.Add("Região 4");

            //await Navigation.PopAsync();
        }
        async void OnButtonClicked3(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new MainPage());
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            Resp1.Text = String.Format("Preço por hora (garçom): {0}", value);
        }
        void OnSliderValueChanged2(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            Resp2.Text = String.Format("Preço por hora (fritadeira): {0}", value);
        }
        void OnSliderValueChanged3(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            Resp3.Text = String.Format("Preço por hora (copeira): {0}", value);
        }
    }
}