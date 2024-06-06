namespace MineWiki.Pages;

public partial class AbaCraftingPage : ContentPage
{
	public AbaCraftingPage()
	{
		InitializeComponent();
	}

    private async void BtnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
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

    private async void BtnSecreto_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbaSecretaPage());
    }
}