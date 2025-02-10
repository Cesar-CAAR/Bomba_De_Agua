namespace Bomba_De_Agua
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();



            // Registro de rutas
            Routing.RegisterRoute(nameof(Inicio), typeof(Inicio));
            Routing.RegisterRoute(nameof(Historial), typeof(Historial));
            Routing.RegisterRoute(nameof(Temporizador), typeof(Temporizador));
        }
    }
}
