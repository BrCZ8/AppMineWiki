namespace MineWiki.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
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

    private async void btnCraftingTab_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbaCraftingPage());
    }

    private async void btnPocaoAba_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbaPocaoPage());
    }
}