namespace MineWiki.Pages;

public partial class UsuarioPage : ContentPage
{
	public UsuarioPage()
	{
		InitializeComponent();
	}

    private async void btnAlterar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new AlterarSenha());
    }

    private async void btnPesquisarTab_Clicked(object sender, EventArgs e)
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

    private async void BtnApagar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeletarPage());

    }
}