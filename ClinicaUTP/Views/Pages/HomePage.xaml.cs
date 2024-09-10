namespace ClinicaUtpNav.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        ShowLoginView();
    }
    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        var clickedButton = sender as Button; // Convertir sender a Button
        if (clickedButton != null)
        {
            ChangeButtonColor(clickedButton);
            ShowLoginView();
        }
    }

    private void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        var clickedButton = sender as Button; // Convertir sender a Button
        if (clickedButton != null)
        {
            ChangeButtonColor(clickedButton);
            ShowRegisterView();
        }
    }

    private void ShowLoginView()
    {
        // Cargar y mostrar la vista de inicio de sesión
        ContentContainer.Content = new LoginView();
    }

    private void ShowRegisterView()
    {
        // Cargar y mostrar la vista de registro
        ContentContainer.Content = new RegisterView();
    }


     private void ChangeButtonColor(Button clickedButton)
    {
        // Restablecer el color de fondo de ambos botones
        RegisterButton.BackgroundColor = Color.FromArgb("#244162");
        LoginButton.BackgroundColor = Color.FromArgb("#244162");

        // Cambiar el color de fondo del botón clicado a amarillo usando formato hexadecimal
        if (clickedButton != null)
        {
            clickedButton.BackgroundColor = Color.FromArgb("#D4AF37");
        }
    }
}