namespace ClinicaUTP.Components;

public partial class TopBarS : ContentView
{
    public static readonly BindableProperty TopTitleProperty = BindableProperty.Create(nameof(title), typeof(string), typeof(TopBarS), string.Empty);

    public string title
    {
        get => (string)GetValue(TopBarS.TopTitleProperty);
        set => SetValue(TopBarS.TopTitleProperty, value);
    }

    public static readonly BindableProperty visibleBackButtonProperty = BindableProperty.Create(
            nameof(visibleBackButton),
            typeof(bool),
            typeof(TopBarS),
            true);

    public bool visibleBackButton
    {
        get => (bool)GetValue(visibleBackButtonProperty);
        set => SetValue(visibleBackButtonProperty, value);
    }
    public TopBarS()
    {
        InitializeComponent();
    }

    public void backButton(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}