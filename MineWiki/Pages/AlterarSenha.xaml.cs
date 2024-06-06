namespace MineWiki.Pages;

public partial class AlterarSenha : ContentPage
{
	public AlterarSenha()
	{
		InitializeComponent();
	}

    private async void BtnVoltar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}