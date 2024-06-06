using MineWiki.Model;

namespace MineWiki.Pages;

public partial class DeletarPage : ContentPage
{
	public DeletarPage()
	{
        InitializeComponent();
	}

    private async void BtnDeletar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    private async void BtnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}