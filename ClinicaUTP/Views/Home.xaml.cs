namespace ClinicaUTP.Views;
using ClinicaUTP.Models;
using System.Collections.ObjectModel;

public partial class Home : ContentPage
{
    public ObservableCollection<CardModel> Cards { get; set; }

    public Home()
	{
        InitializeComponent();

        Cards = new ObservableCollection<CardModel>
        {
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Consultas y evaluaciones m�dicas con previa cita",
                CardDescription = "Atenci�n m�dica programada para evaluar y diagnosticar al paciente, permitiendo una planificaci�n adecuada del tiempo y recursos."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Consultas y evaluaciones de urgencias",
                CardDescription = "Atenci�n inmediata para situaciones m�dicas que requieren intervenci�n r�pida debido a la gravedad o riesgo de complicaciones."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Referencias a especialidades m�dicas",
                CardDescription = "Derivaci�n del paciente a un especialista cuando la condici�n m�dica requiere un conocimiento o tratamiento m�s espec�fico."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Certificado de buena salud",
                CardDescription = "Documento oficial que certifica que una persona ha sido evaluada m�dicamente y est� en condiciones de salud adecuadas."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Solicitudes de estudios de gabinete",
                CardDescription = "Peticiones para realizar estudios diagn�sticos como radiograf�as, ecograf�as, o an�lisis de laboratorio, necesarios para un diagn�stico m�s preciso."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Administraci�n gratuita de medicamentos b�sicos",
                CardDescription = "Provisi�n de medicamentos esenciales sin costo, generalmente como parte del tratamiento inicial de enfermedades comunes."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Curaciones y corte de puntos",
                CardDescription = "Procedimientos para cuidar heridas o retirar suturas despu�s de una cirug�a o lesi�n, asegurando una correcta cicatrizaci�n."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Inhaloterapias",
                CardDescription = "Tratamientos respiratorios que administran medicamentos a trav�s de inhaladores o nebulizadores para aliviar afecciones respiratorias."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Aplicaci�n de medicamentos inyectables",
                CardDescription = "Administraci�n de medicamentos mediante inyecciones, ya sea intramuscular, intravenosa, o subcut�nea, seg�n sea necesario."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Toma de presi�n arterial",
                CardDescription = "Medici�n de la presi�n en las arterias, esencial para detectar hipertensi�n u otros problemas cardiovasculares."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Frecuencia card�aca",
                CardDescription = "Medici�n del n�mero de latidos del coraz�n por minuto, importante para evaluar la salud cardiovascular."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Frecuencia respiratoria",
                CardDescription = "Conteo del n�mero de respiraciones por minuto, utilizado para evaluar la funci�n respiratoria y detectar posibles anomal�as."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Control de peso y talla",
                CardDescription = "Medici�n del peso y la estatura para evaluar el estado nutricional y crecimiento, y para calcular el �ndice de masa corporal (IMC)."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Toma de glicemia capilar",
                CardDescription = "Medici�n r�pida del nivel de glucosa en la sangre, generalmente a trav�s de una peque�a muestra de sangre tomada del dedo, crucial para el control de la diabetes."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Video consultas de medicina general, a trav�s de citas",
                CardDescription = "Consultas m�dicas realizadas por videollamada, permitiendo el acceso a la atenci�n m�dica desde cualquier lugar, ideal para seguimiento o condiciones menos graves."
            }
        };

        BindingContext = this;
    }

    private async void notificate(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Notificate());
    }

}