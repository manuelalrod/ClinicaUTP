namespace ClinicaUtpNav.Pages;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
    private async void OnNextPageButtonClicked(object sender, EventArgs e) => await Navigation.PushAsync(new HomePage()); // Cambia "NextPage" al nombre de tu página de destino
}