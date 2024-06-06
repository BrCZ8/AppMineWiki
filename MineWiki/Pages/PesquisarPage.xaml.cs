namespace MineWiki.Pages;

public partial class PesquisarPage : ContentPage
{
	public PesquisarPage()
	{
		InitializeComponent();
	}

    private async void BtnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void btnPesquisar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PesquisarPage());
    }

    private async void btnHome_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void btnUser_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UsuarioPage());
    }
}