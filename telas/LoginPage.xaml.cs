namespace telas;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
        InitializeComponent();
	}

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
		if (usuarioInput.Text == "gabs" && senhaInput.Text == "1234")
		{
            // redirecionar para outra tela
            App.Current.MainPage = new AppShell();
		} 
		else
		{
			await DisplayAlert("Alerta", "Usuário ou senha invalidos", "OK");
		}
    }
}