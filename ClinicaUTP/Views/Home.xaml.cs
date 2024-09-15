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
                CardTitle = "Consultas y evaluaciones médicas con previa cita",
                CardDescription = "Atención médica programada para evaluar y diagnosticar al paciente, permitiendo una planificación adecuada del tiempo y recursos."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Consultas y evaluaciones de urgencias",
                CardDescription = "Atención inmediata para situaciones médicas que requieren intervención rápida debido a la gravedad o riesgo de complicaciones."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Referencias a especialidades médicas",
                CardDescription = "Derivación del paciente a un especialista cuando la condición médica requiere un conocimiento o tratamiento más específico."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Certificado de buena salud",
                CardDescription = "Documento oficial que certifica que una persona ha sido evaluada médicamente y está en condiciones de salud adecuadas."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Solicitudes de estudios de gabinete",
                CardDescription = "Peticiones para realizar estudios diagnósticos como radiografías, ecografías, o análisis de laboratorio, necesarios para un diagnóstico más preciso."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Administración gratuita de medicamentos básicos",
                CardDescription = "Provisión de medicamentos esenciales sin costo, generalmente como parte del tratamiento inicial de enfermedades comunes."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Curaciones y corte de puntos",
                CardDescription = "Procedimientos para cuidar heridas o retirar suturas después de una cirugía o lesión, asegurando una correcta cicatrización."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Inhaloterapias",
                CardDescription = "Tratamientos respiratorios que administran medicamentos a través de inhaladores o nebulizadores para aliviar afecciones respiratorias."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Aplicación de medicamentos inyectables",
                CardDescription = "Administración de medicamentos mediante inyecciones, ya sea intramuscular, intravenosa, o subcutánea, según sea necesario."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Toma de presión arterial",
                CardDescription = "Medición de la presión en las arterias, esencial para detectar hipertensión u otros problemas cardiovasculares."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Frecuencia cardíaca",
                CardDescription = "Medición del número de latidos del corazón por minuto, importante para evaluar la salud cardiovascular."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Frecuencia respiratoria",
                CardDescription = "Conteo del número de respiraciones por minuto, utilizado para evaluar la función respiratoria y detectar posibles anomalías."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Control de peso y talla",
                CardDescription = "Medición del peso y la estatura para evaluar el estado nutricional y crecimiento, y para calcular el índice de masa corporal (IMC)."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Toma de glicemia capilar",
                CardDescription = "Medición rápida del nivel de glucosa en la sangre, generalmente a través de una pequeña muestra de sangre tomada del dedo, crucial para el control de la diabetes."
            },
            new CardModel
            {
                CardImage = "vaccine.svg",
                CardTitle = "Video consultas de medicina general, a través de citas",
                CardDescription = "Consultas médicas realizadas por videollamada, permitiendo el acceso a la atención médica desde cualquier lugar, ideal para seguimiento o condiciones menos graves."
            }
        };

        BindingContext = this;
    }

    private async void notificate(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Notificate());
    }

}