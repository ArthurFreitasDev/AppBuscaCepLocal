using AppBuscaCepLocal.Model;
using AppBuscaCepLocal.Services;

namespace AppBuscaCepLocal
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Buscar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Endereco? dados_endereco = await DataServiceCep.GetEnderecoByCep(txt_cep.Text);

                BindingContext = dados_endereco;
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }

}
