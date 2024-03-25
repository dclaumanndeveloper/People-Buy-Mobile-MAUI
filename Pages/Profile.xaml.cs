namespace PeopleBuyMobile.Pages;

public partial class Profile : ContentPage
{
    public string Nome { get; set; }
    public string Email { get; set; }

    public Profile()
	{
        Nome = "Nome do Usuário";
        Email = "usuario@email.com";
        InitializeComponent();
	}
}