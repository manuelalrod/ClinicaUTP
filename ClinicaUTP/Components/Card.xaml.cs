namespace ClinicaUTP.Components;

public partial class Card : ContentView
{
    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(
            nameof(CardTitle),
            typeof(string),
            typeof(Card),
            string.Empty);

    public string CardTitle
    {
        get => (string)GetValue(CardTitleProperty);
        set => SetValue(CardTitleProperty, value);
    }

    public static readonly BindableProperty CardImageProperty = BindableProperty.Create(
        nameof(CardImage),
        typeof(string),
        typeof(Card),
        string.Empty);

    public string CardImage
    {
        get => (string)GetValue(CardImageProperty);
        set => SetValue(CardImageProperty, value);
    }

    public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(
        nameof(CardDescription),
        typeof(string),
        typeof(Card),
        string.Empty);

    public string CardDescription
    {
        get => (string)GetValue(CardDescriptionProperty);
        set => SetValue(CardDescriptionProperty, value);
    }

    // Constructor
    public Card()
    {
        InitializeComponent();
    }
}