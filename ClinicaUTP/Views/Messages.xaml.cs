namespace ClinicaUTP.Views;

public partial class Messages : ContentPage
{
	public Messages()
	{
		InitializeComponent();
	}

    private void backButton(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

}