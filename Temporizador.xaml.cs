namespace Bomba_De_Agua;

public partial class Temporizador : ContentPage
{
	public Temporizador()
	{
		InitializeComponent();
	}

	// Este metodo cuando lo pulsa el usuario enciende una bomba de agua
	// y despues de encender la bomba de agua, redirecciona al usuario a MainPage
    private void Encender_y_Inicio(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Inicio());
    }
}