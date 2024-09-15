namespace ClinicaUTP.Components;
using ClinicaUTP.Views;

public partial class TopBarP : ContentView
{
    public TopBarP()
    {
        InitializeComponent();
    }
    public void notificate(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Notificate());
    }

    public void appointment(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Appointments());
    }

    public void settings(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Settings());
    }
}